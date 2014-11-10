using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using ShapeFind.calculating;
using ShapeFind.lookup;
using ShapeFind.shapes;

namespace ShapeFind
{
    public partial class MainForm : Form
    {
        private List<Shape> _shapeList;
        private ShapeLookupTable _shapeLookupTable;

        public MainForm()
        {
            InitializeComponent();

            pictureBox.MouseMove += pictureBox_MouseEvent;
        }

        public void ExecuteThreadSafe(Action action)
        {
            if (InvokeRequired)
                Invoke(action);
            else
                action.Invoke();
        }

        private void button_generate_Click(object sender, EventArgs e)
        {
            GenerateShapes();
        }

        private void GenerateShapes()
        {
            button_generate.Enabled = false;
            toolStripStatusLabel_status.Text = @"generiere Formen...";

            Size minSize = new Size(
                (int)numericUpDown_minSize_x.Value,
                (int)numericUpDown_minSize_y.Value);
            Size maxSize = new Size(
                (int)numericUpDown_maxSize_x.Value,
                (int)numericUpDown_maxSize_y.Value);

            ShapeAreaBounds bounds = new ShapeAreaBounds(
                    pictureBox.ClientSize, minSize, maxSize);

            ShapeGenerationParameters parameters = new ShapeGenerationParameters(
                bounds,
                checkBox_genRectangles.Checked,
                checkBox_genTriangles.Checked,
                checkBox_genEllipses.Checked,
                (int)numericUpDown_shapeCount.Value,
                pictureBox.ClientSize
                );

            GenerateShapesTask task = new GenerateShapesTask(parameters);

            task.ContinueWith(action =>
            {
                ShapeGenerationResult result = action.Result;
                pictureBox.Image = result.DrawingImage;

                _shapeList = result.ShapeList;

                ExecuteThreadSafe(() =>
                {
                    toolStripStatusLabel_status.Text =
                        String.Format("Generieren von Formen dauerte {0}ms",
                        result.Runtime.TotalMilliseconds);
                });

                if (radioButton_countMethod_lookup.Checked)
                {
                    GenerateShapeLookupTable();
                }
                else if (radioButton_countMethod_calculate.Checked)
                {
                    _shapeLookupTable = null;
                    ExecuteThreadSafe(() => button_generate.Enabled = true);
                }
            });

            task.Start();
        }

        private void pictureBox_MouseEvent(object sender, MouseEventArgs e)
        {
            Point translPoint = new Point(e.X, pictureBox.ClientSize.Height - e.Y - 1);
            CountShapes(translPoint);
        }

        private void pictureBox_MouseLeave(object sender, EventArgs e)
        {
            label_countedShapes.Text = @"0";
            toolStripStatusLabel_x.Text = String.Empty;
            toolStripStatusLabel_y.Text = String.Empty;
        }

        private void CountShapes(Point p)
        {
            toolStripStatusLabel_x.Text = String.Format("x: {0,5}", p.X);
            toolStripStatusLabel_y.Text = String.Format("y: {0,5}", p.Y);

            if (_shapeList == null)
                return;

            ShapeFindTask findTask;
            ShapeFindParameters findingParameters =
                    new ShapeFindParameters(_shapeList, _shapeLookupTable, p);

            if (radioButton_countMethod_calculate.Checked)
            {
                findTask = new CalculatingShapeFindTask(findingParameters);
            }
            else
            {
                if (_shapeLookupTable == null)
                    return;
                findTask = new LookupShapeFindTask(findingParameters);
            }

            findTask.ContinueWith(action =>
            {
                ShapeFindTaskResult result = action.Result;
                ExecuteThreadSafe(() =>
                {
                    label_countedShapes.Text = String.Format("{0}", result.ShapeCount);
                });
            });

            findTask.Start();
        }

        private void checkBox_countOnClick_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_countOnClick.Checked)
            {
                pictureBox.MouseMove -= pictureBox_MouseEvent;
                pictureBox.MouseClick += pictureBox_MouseEvent;
            }
            else
            {
                pictureBox.MouseClick -= pictureBox_MouseEvent;
                pictureBox.MouseMove += pictureBox_MouseEvent;
            }
        }

        private void GenerateShapeLookupTable()
        {
            if (_shapeList == null)
                return;

            toolStripStatusLabel_status.Text = @"generiere Formen-Lookup...";

            ShapeLookupGenerationParameters parameters =
                new ShapeLookupGenerationParameters(_shapeList, pictureBox.ClientSize);
            GenerateShapeLookupTask task = new GenerateShapeLookupTask(parameters);

            task.ContinueWith(action =>
            {
                _shapeLookupTable = action.Result.LookupTable;

                ExecuteThreadSafe(() =>
                {
                    button_generate.Enabled = true;
                    toolStripStatusLabel_status.Text =
                        String.Format("Generieren von Formen-Lookup dauerte {0}ms",
                        action.Result.Runtime.TotalMilliseconds);
                });
            });
            task.Start();
        }

        private void radioButton_countMethod_lookup_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_countMethod_lookup.Checked && _shapeLookupTable == null)
            {
                GenerateShapeLookupTable();
            }
        }
    }
}
