using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book("Soumya's grade book");
            book.AddGrade(90.9);
            book.AddGrade(89.0);
            book.AddGrade(91.9);
            book.ShowStatistics();
            
            
        }
    }
}
