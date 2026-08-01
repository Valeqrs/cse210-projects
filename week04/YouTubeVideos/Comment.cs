namespace YouTubeVideos
{
    public class Comment
    {
        // Member variables use _underscoreCamelCase
        private string _commenterName;
        private string _commentText;

        // Constructor
        public Comment(string commenterName, string commentText)
        {
            _commenterName = commenterName;
            _commentText = commentText;
        }

        // Public properties (or methods) to access data – TitleCase for methods
        public string GetCommenterName()
        {
            return _commenterName;
        }

        public string GetCommentText()
        {
            return _commentText;
        }
    }
}