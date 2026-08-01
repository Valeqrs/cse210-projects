using System.Collections.Generic;

namespace YouTubeVideos
{
    public class Video
    {
        // Member variables use _underscoreCamelCase
        private string _title;
        private string _author;
        private int _lengthSeconds;
        private List<Comment> _comments;

        // Constructor
        public Video(string title, string author, int lengthSeconds)
        {
            _title = title;
            _author = author;
            _lengthSeconds = lengthSeconds;
            _comments = new List<Comment>();
        }

        // Method to add a comment (TitleCase)
        public void AddComment(Comment comment)
        {
            _comments.Add(comment);
        }

        // Method to return the number of comments (TitleCase)
        public int GetNumberOfComments()
        {
            return _comments.Count;
        }

        // Getters for video details (TitleCase)
        public string GetTitle()
        {
            return _title;
        }

        public string GetAuthor()
        {
            return _author;
        }

        public int GetLengthSeconds()
        {
            return _lengthSeconds;
        }

        // Method to get all comments (for display)
        public List<Comment> GetComments()
        {
            return _comments;
        }
    }
}