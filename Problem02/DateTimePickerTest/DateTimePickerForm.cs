using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DateTimePickerTest
{
    public partial class DateTimePicker : Form
    {
        public DateTimePicker()
        {
            InitializeComponent();
        }

        private void dropOffDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            DateTime dropOffDate = dropOffDateTimePicker.Value;
            // add extra time when items are dropped of Sunday
            if (dropOffDate.DayOfWeek == DayOfWeek.Friday ||
                dropOffDate.DayOfWeek == DayOfWeek.Saturday ||
                dropOffDate.DayOfWeek == DayOfWeek.Sunday)
            {
                // estimate three days for deliver
                outputLabel.Text = dropOffDate.AddDays(3).ToLongDateString();
            }
            else
            {
                // otherwise estimate only two days for deliver
                outputLabel.Text = dropOffDate.AddDays(2).ToLongDateString();
            }
        }

        private void DateTimePicker_Load(object sender, EventArgs e)
        {
            // user cannot select days before today
            dropOffDateTimePicker.MinDate = DateTime.Today;

            // user can only select days up to one year in the future
            dropOffDateTimePicker.MaxDate = DateTime.Today.AddYears(1);
        }
    }
}
