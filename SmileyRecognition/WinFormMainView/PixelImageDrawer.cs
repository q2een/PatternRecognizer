using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace PatternRecognizer
{
    /// <summary>
    /// Предоставляет элемент управления, предназначенный для имитации рисования пиксельного рисунка. Представляет собой сетку из кнопок.
    /// </summary>
    class PixelImageDrawer : TableLayoutPanel
    {
        /// <summary>
        /// Возвращает коллекцию пикселей текущего рисунка.
        /// </summary>
        public double[] CurrentImage { get; private set; }

        /// <summary>
        /// Происходит при нажатии на кнопку, имитирующую пиксел изображения.
        /// </summary>
        public event EventHandler PixelButtonClick = delegate { };
        
        /// <summary>
        /// Предоставляет класс для имитации формирования пиксельного рисунка.
        /// </summary>
        /// <param name="columnsCount">Количество колонок - количество пикселей в длину.</param>
        /// <param name="rowsCount">Количество строк - количество пикселей в высоту.</param>
        public PixelImageDrawer(int columnsCount, int rowsCount)
        {
            this.CurrentImage = new double[rowsCount * columnsCount].Select(i => 1.0).ToArray();

            this.RowCount = rowsCount;
            this.ColumnCount = columnsCount;

            this.Dock = DockStyle.Fill;
            this.Padding = new Padding(0);
            // Создание сетки пикселей.
            for (int i = 0; i < rowsCount * columnsCount; i++)
            {
                if (i < columnsCount + 1)
                    this.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100 /( (float)columnsCount + 1)));

                if (i < rowsCount)
                    this.RowStyles.Add(new RowStyle(SizeType.Percent, 100 / (float)rowsCount));


                this.Controls.Add(CreatePixelButton(i));
            }
        }

        /// <summary>
        /// Отрисовывает заданное изображение.
        /// </summary>
        /// <param name="image">Массив пикселей. 1 - белый цвет, 0 - черный</param>
        public void SetImage(double [] image)
        {
            for (int i = 0; i < image.Length; i++)
            {
                if (CurrentImage[i] == image[i])
                    continue;

                Controls[i].BackColor = CurrentImage[i] == 1 ? Color.Black : Color.White;
            }

            CurrentImage = image;
        }

        /// <summary>
        /// Очищает изображение.
        /// </summary>
        public void Clear()
        {
            SetImage(new double[RowCount * ColumnCount].Select(i => 1.0).ToArray());
        }

        // Создает элемент управления "Кнопка", которая служит имитацией пиксела на рисунке.  
        private Button CreatePixelButton(int index)
        {
            var button = new Button()
            {
                Dock = DockStyle.Fill,
                FlatStyle = FlatStyle.Flat,
                BackColor = Color.White,
                Tag = index,
                Margin = new Padding(1),                 
            };

            button.Click += PixelButton_Click;

            return button;
        }

        // Обработка события нажатия на кнопку, имитирующую пиксел.
        private void PixelButton_Click(object sender, EventArgs e)
        {
            var button = sender as Button;        
            int index = int.Parse(button.Tag.ToString());

            CurrentImage[index] = CurrentImage[index] == 1 ? 0 : 1;  
            button.BackColor = CurrentImage[index] == 0 ? Color.Black : Color.White;

            PixelButtonClick(sender, e);
        }
    }
}
