using System;
using System.Collections.Generic;

namespace lab05
{
    public class MyMatrix
    {
        private int lines_;
        private int columns_;
        private int[,] matrix_;
        public int Lines { get; set; }
        public int Columns { get; set; }
        public MyMatrix()
        {
            lines_ = 0;
            columns_ = 0;
            matrix_ = new int[lines_, columns_];
        }
        public MyMatrix(int input_lines, int input_columns)
        {
            lines_ = input_lines;
            columns_ = input_columns;
            matrix_ = new int[input_lines, input_columns];
            Random rangom = new Random();
            Console.WriteLine("Enter an gap: ");
            int first = Convert.ToInt16(Console.ReadLine());
            int last = Convert.ToInt16(Console.ReadLine());
            for (int i = 0; i < lines_; ++i)
            {
                for (int j = 0; j < columns_; ++j)
                {
                    matrix_[i, j] = rangom.Next(first, last);
                }
            }
        }
        public void Fill()
        {
            Random rangom = new Random();
            Console.WriteLine("Enter an gap: ");
            int first = Convert.ToInt16(Console.ReadLine());
            int last = Convert.ToInt16(Console.ReadLine());
            for (int i = 0; i < lines_; ++i)
            {
                for (int j = 0; j < columns_; ++j)
                {
                    matrix_[i, j] = rangom.Next(first, last);
                }
            }
        }

        public void ChangeSize(int m, int n)
        {
            MyMatrix new_matrix = new MyMatrix();
            new_matrix.lines_ = m;
            new_matrix.columns_ = n;
            new_matrix.matrix_ = new int[m, n];
            for (int i = 0; i < lines_ && i < m; ++i)
            {
                for (int j = 0; j < columns_ && j < n; ++j)
                {
                    new_matrix[i, j] = this[i, j];
                }
            }
            new_matrix.Fill();
            matrix_ = new_matrix.matrix_;
            lines_ = m;
            columns_ = n;
        }


        public void Show()
        {
            for (int i = 0; i < lines_; ++i)
            {
                for (int j = 0; j < columns_; ++j)
                {
                    Console.Write(matrix_[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        public void ShowPartialy(int first_arg, int second_arg)
        {
            if (first_arg == 0 || second_arg == 0)
            {
                throw new Exception("args cant be 0");
            }
            for (int i = 0; i < first_arg; ++i)
            {
                for (int j = 0; j < second_arg; ++j)
                {
                    Console.Write(matrix_[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        public int this[int i, int j]
        {
            get => matrix_[i, j];
            set => matrix_[i, j] = value;
        }
    }
}
