using GradeBook.Enums;

namespace GradeBook.GradeBooks
{
    public class StandardGradeBook : BaseGradeBook
    {
        public StandardGradeBook(string name) : base(name)
        {
            Type = StandardGradeBook.Standard;
        }

        public static GradeBookType Standard { get; }
    }
}
