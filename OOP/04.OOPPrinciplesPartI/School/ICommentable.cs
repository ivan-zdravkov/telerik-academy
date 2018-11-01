using System;

namespace School
{
    interface ICommentable
    {
        void AddComment(string comment);
        string GetComment();
    }
}
