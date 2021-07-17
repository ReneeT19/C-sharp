using System;


namespace StructureAndEnum
{
    struct Books
    {
        int ISBN;
        string BookName;
        string AuthorName;

        public Books(int ISBN,string BookName,string AuthorName)
        {
            this.ISBN = ISBN;
            this.BookName = BookName;
            this.AuthorName = AuthorName;
        }

        public string Display()
        {
            return $"Book ISBN={ISBN} BookName={BookName} AuthorName={AuthorName}";
        }
    }
}
