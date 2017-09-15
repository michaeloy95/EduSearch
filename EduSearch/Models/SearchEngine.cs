using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lucene.Net.Analysis; // for Analyser
using Lucene.Net.Documents; // for Document and Field
using Lucene.Net.Index; //for Index Writer
using Lucene.Net.Store; //for Directory
using Lucene.Net.Search; // for IndexSearcher
using Lucene.Net.QueryParsers;  // for QueryParser
using Lucene.Net.Analysis.Snowball; // for snowball analyser 

namespace EduSearch.Models
{
    public class SearchEngine
    {
        /// <summary>
        /// Index directory of the collection
        /// </summary>
        private Directory indexDirectory;

        /// <summary>
        /// Analyzer of the search engine
        /// </summary>
        private Analyzer analyzer;

        /// <summary>
        /// Index writer for pushing documents to index
        /// </summary>
        private IndexWriter writer;

        /// <summary>
        /// Index searcher for document search
        /// </summary>
        private IndexSearcher searcher;

        /// <summary>
        /// Query parser to parse text to query
        /// </summary>
        private QueryParser parser;

        /// <summary>
        /// Similarity weighting
        /// </summary>
        private Similarity newSimilarity;

        /// <summary>
        /// Version of the Lucene package used
        /// </summary>
        private const Lucene.Net.Util.Version VERSION = Lucene.Net.Util.Version.LUCENE_30;

        /// <summary>
        /// Document ID field name
        /// </summary>
        private const string ID_FN = "Id";

        /// <summary>
        /// Title field name
        /// </summary>
        private const string TITLE_FN = "Title";

        /// <summary>
        /// Author field name
        /// </summary>
        private const string AUTHOR_FN = "Author";

        /// <summary>
        /// Bibliography field name
        /// </summary>
        private const string BIBLIOGRAPHY_FN = "Bibliography";

        /// <summary>
        /// Abstract field name
        /// </summary>
        private const string ABSTRACT_FN = "Abstract";

        public enum IndexFieldName
        {
            Id,
            Title,
            Author,
            Bibliography,
            Abstract
        };

        /// <summary>
        /// Search Engine default constructor
        /// </summary>
        public SearchEngine()
        {
            indexDirectory = null;
            writer = null;
            analyzer = null;
        }

        /// <summary>
        /// Creates the index at indexPath
        /// </summary>
        /// <param name="indexPath">Directory path to create the index</param>
        public void CreateIndex(string indexPath)
        {
            indexDirectory = Lucene.Net.Store.FSDirectory.Open(indexPath);
            analyzer = new Lucene.Net.Analysis.Standard.StandardAnalyzer(VERSION);
            IndexWriter.MaxFieldLength mfl = new IndexWriter.MaxFieldLength(IndexWriter.DEFAULT_MAX_FIELD_LENGTH);
            writer = new Lucene.Net.Index.IndexWriter(indexDirectory, analyzer, true, mfl);
        }

        /// <summary>
        /// Indexes the given text
        /// </summary>
        /// <param name="text">Text to index</param>
        /// <param name="indexFieldName">Index field name</param>
        public void IndexText(string text, IndexFieldName indexFieldName)
        {
            string fieldName = (indexFieldName == IndexFieldName.Id) ? ID_FN :
                               (indexFieldName == IndexFieldName.Title) ? TITLE_FN :
                               (indexFieldName == IndexFieldName.Author) ? AUTHOR_FN :
                               (indexFieldName == IndexFieldName.Bibliography) ? BIBLIOGRAPHY_FN :
                               ABSTRACT_FN;
            Lucene.Net.Documents.Field field = new Field(fieldName, text, Field.Store.YES, Field.Index.ANALYZED, Field.TermVector.WITH_POSITIONS_OFFSETS);
            Lucene.Net.Documents.Document doc = new Lucene.Net.Documents.Document();
            doc.Add(field);
            writer.AddDocument(doc);
        }

        /// <summary>
        /// Flushes buffer and closes the index
        /// </summary>
        public void CleanUpIndexer()
        {
            writer.Optimize();
            writer.Flush(true, true, true);
            writer.Dispose();
        }

        /// <summary>
        /// Creates searcher
        /// </summary>
        public void CreateSearcher()
        {
            searcher = new IndexSearcher(indexDirectory);
        }

        /// <summary>
        /// Creates parser
        /// </summary>
        /// <param name="indexFieldName">Index field name</param>
        public void CreateParser(IndexFieldName indexFieldName)
        {
            string fieldName = (indexFieldName == IndexFieldName.Id) ? ID_FN :
                               (indexFieldName == IndexFieldName.Title) ? TITLE_FN :
                               (indexFieldName == IndexFieldName.Author) ? AUTHOR_FN :
                               (indexFieldName == IndexFieldName.Bibliography) ? BIBLIOGRAPHY_FN :
                               ABSTRACT_FN;
            parser = new QueryParser(VERSION, fieldName, analyzer);
        }

        /// <summary>
        /// Searches newly created index
        /// </summary>
        /// <param name="query">The search query</param>
        /// <returns>Ranked list of relevant documents</returns>
        public TopDocs SearchIndex(string query)
        {
            Query q = parser.Parse(query);
            TopDocs td = searcher.Search(q, 100);
            return td;
        }

        /// <summary>
        /// Flushes search buffer and closes searcher's index
        /// </summary>
        public void CleanUpSearcher()
        {
            searcher.Dispose();
        }
    }
}
