using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduSearch.Models
{
    public class Document
    {
        /// <summary>
        /// Document's Id
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Document's Title
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Document's Author
        /// </summary>
        public string Author { get; set; }

        /// <summary>
        /// Document's Bibliography
        /// </summary>
        public string Bibliography { get; set; }

        /// <summary>
        /// Document's Abstract
        /// </summary>
        public string Abstract { get; set; }

        /// <summary>
        /// Default Document constructor
        /// </summary>
        public Document()
        {
            Id = string.Empty;
            Title = string.Empty;
            Author = string.Empty;
            Bibliography = string.Empty;
            Abstract = string.Empty;
        }
    }
}
