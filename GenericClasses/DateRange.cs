namespace GenericClasses
{
    public class DateRange
    {
        DateTime _start;
        DateTime _end;

        public DateTime Start
        {
            get { return _start; }
            set { _start = value; }
        }
        public DateTime End
        {
            get { return _end; }
            set { _end = value; }
        }
    }
}
