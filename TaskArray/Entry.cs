using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskArray
{
  public partial class frmEntry : Form
  {
    private const int WIDTH_COLS = 50;
    const int ROW_INDEX_NULL = 0;

    public frmEntry()
    {
      InitializeComponent();
    }

    private void btnDefault_Click(object sender, EventArgs e)
    {
      const int DEFAULT_ELEMENT_COUNT = 10;

      editLength.Text = Convert.ToString(DEFAULT_ELEMENT_COUNT);

      gridArray.ColumnCount = DEFAULT_ELEMENT_COUNT;

      fillGridRandomNumber();
      setColumnWidth(gridArray, WIDTH_COLS);
    }

    private void fillGridRandomNumber()
    {
      const int MIN_VALUE = -10;
      const int MAX_VALUE = 10;

      Random genRand = new Random();
      int number;

      for (int i = 0; i < gridArray.ColumnCount; i++)
      {
        number = genRand.Next(MIN_VALUE, MAX_VALUE);

        gridArray.Rows[ROW_INDEX_NULL].Cells[i].Value = number;
      }
    }

    private void setColumnWidth(DataGridView grid, int width)
    {
      for (int j = 0; j < grid.ColumnCount; j++)
      {
        grid.Columns[j].Width = width;
      }
    }

    private void btnInit_Click(object sender, EventArgs e)
    {
      gridArray.ColumnCount = Convert.ToInt32(editLength.Text);

      setColumnWidth(gridArray, WIDTH_COLS);

      if (chkRandom.Checked)
      {
        fillGridRandomNumber();
      }
    }

    private void clearElementsForm()
    {
      editLength.Text = "";
      editNumber.Clear();
      gridArray.ColumnCount = 0;

      clearResults();
    }

    private void clearResults()
    {
      editResult.Text = "";
      gridResult.ColumnCount = 0;
    }

    private void btnClear_Click(object sender, EventArgs e)
    {
      clearElementsForm();
    }

    private void btnTask1_Click(object sender, EventArgs e)
    {
      int number = Convert.ToInt32(editNumber.Text);
      int[] source = getSourceNumbers();
      int[] results = new int[gridArray.ColumnCount];
      int index_result = 0;
      int summ = 0;

      for (int i = 0; i < source.Length; i++)
      {
        if (source[i] % number == 0)
        {
          summ += source[i];
          results[index_result++] = source[i];
        }
      }

      results = copyArrayToLengh(results, index_result);
      showResult(results, summ);
    }

    private void showResult(int[] arr, int numbers)
    {
      editResult.Text = Convert.ToString(numbers);
      showResult(arr);
    }

    private void showResult(int[] arr)
    {
      fillGridNumbers(gridResult, arr);
      setColumnWidth(gridResult, WIDTH_COLS);
    }

    private int[] getSourceNumbers()
    {
      int[] source = new int[gridArray.ColumnCount];

      for (int i = 0; i < source.Length; i++)
      {
        source[i] = Convert.ToInt32(gridArray.Rows[ROW_INDEX_NULL].Cells[i].Value);
      }

      return source;
    }


    private int[] copyArrayToLengh(int[] arr, int count)
    {
      int[] result = new int[count];

      for (int i = 0; i < result.Length; i++)
      {
        result[i] = arr[i];
      }

      return result;
    }

    private void fillGridNumbers(DataGridView grid, int[] arr)
    {
      int count = arr.Length;

      grid.ColumnCount = count;

      for (int i = 0; i < count; i++)
      {
        grid.Rows[ROW_INDEX_NULL].Cells[i].Value = arr[i];
      }
    }

    private void btnTask2_Click(object sender, EventArgs e)
    {
      int[] source = getSourceNumbers();
      int[] results = new int[gridArray.ColumnCount];
      int index_result = 0;
      int summ = 0;
      bool isNullNumber = false;

      for (int i = 0; i < source.Length; i++)
      {
        // Фиксация первого нулевого элемента массива
        if (isNullNumber == false && source[i] == 0)
        {
          isNullNumber = true;
          continue;
        }

        // Работа с последующими числами
        summ += Math.Abs(source[i]);
        results[index_result++] = Math.Abs(source[i]);
      }

      results = copyArrayToLengh(results, index_result);
      showResult(results, summ);

    }

    private void btnTask3_Click(object sender, EventArgs e)
    {
      clearResults();

      int[] source = getSourceNumbers();
      int[] results = new int[gridArray.ColumnCount];
      int index_result = 0;
      int multiple = 1;

      int startPos = getStartPosition(source);
      int endPos = getEndPosition(source);

      // Во первых должны быть найдены позиции и между ними
      if (startPos >= 0 && endPos >= 0)
      {
        for (int i = startPos + 1; i < endPos; i++)
        {
          if (source[i] > 0)
          {
            multiple *= source[i];
            results[index_result++] = source[i];
          }
        }

        results = copyArrayToLengh(results, index_result);
        showResult(results, multiple);
      }
    }

    private int getStartPosition(int[] source)
    {
      int position = -1;

      for (int i = 0; i < source.Length; i++)
      {
        if (source[i] < 0)
        {
          position = i;
          break;
        }
      }

      return position;
    }

    private int getEndPosition(int[] source)
    {
      int position = -1;

      for (int i = source.Length - 1; i >= 0; i--)
      {
        if (source[i] < 0)
        {
          position = i;
          break;
        }
      }

      return position;
    }

    private void FrmEntry_Load(object sender, EventArgs e)
    {

    }

    private void gridResult_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {
      if (IsANonHeaderLinkCell(e))
      {
        MoveToLinked(e);
      }
    }

    private bool IsANonHeaderLinkCell(DataGridViewCellEventArgs e)
    {
      throw new NotImplementedException();
    }

    private void MoveToLinked(DataGridViewCellEventArgs e)
    {
      throw new NotImplementedException();
    }
  }
}
