using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduSearch.Models
{
    public class Journal
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
        /// Document's Score
        /// </summary>
        public double Score { get; set; }

        /// <summary>
        /// Default Document constructor
        /// </summary>
        public Journal()
        {
            this.Id = string.Empty;
            this.Title = string.Empty;
            this.Author = string.Empty;
            this.Bibliography = string.Empty;
            this.Abstract = string.Empty;
            this.Score = 1;
        }

        public void Trim()
        {
            this.Id = this.Id.Trim();
            this.Title = this.Title.Trim();
            this.Author = this.Author.Trim();
            this.Bibliography = this.Bibliography.Trim();
            this.Abstract = this.Abstract.Trim();
        }
    }
}
