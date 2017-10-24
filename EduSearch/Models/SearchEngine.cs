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
        private Dictionary<string, List<string>> thesaurus;

        /// <summary>
        /// Porter stemmer
        /// </summary>
        private PorterStemmerAlgorithm.PorterStemmer stemmer;

        /// <summary>
        /// Contains all documents
        /// </summary>
        private Dictionary<string, Journal> allDocuments;

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
        /// Number of documents searched
        /// </summary>
        private const int SEARCH_DOCS_NUM = 1500;

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

        /// <summary>
        /// Index Field Name
        /// </summary>
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
            this.indexDirectory = null;
            this.writer = null;
            this.analyzer = null;
            this.newSimilarity = null;
            InitThesaurus();
        }

        /// <summary>
        /// Creates the index at indexPath
        /// </summary>
        /// <param name="indexPath">Directory path to create the index</param>
        public void CreateIndex(string indexPath)
        {
            this.indexDirectory = Lucene.Net.Store.FSDirectory.Open(indexPath);
            this.analyzer = new Lucene.Net.Analysis.Standard.StandardAnalyzer(VERSION);
            this.newSimilarity = new CustomSimilarity();
            IndexWriter.MaxFieldLength mfl = new IndexWriter.MaxFieldLength(IndexWriter.DEFAULT_MAX_FIELD_LENGTH);
            this.writer = new Lucene.Net.Index.IndexWriter(indexDirectory, analyzer, true, mfl);
<<<<<<< HEAD
            this.writer.SetSimilarity(newSimilarity);
            this.allDocuments = new Dictionary<string, Document>();
=======
            this.allDocuments = new Dictionary<string, Journal>();
>>>>>>> 1ec6d82c33a56f2418bada3d9969271909983521
        }

        /// <summary>
        /// Indexes the given text
        /// </summary>
        /// <param name="myDoc">Document to index</param>
        public void IndexText(Journal myDoc)
        {
            // UPDATE: Only index ID and Abstract
            Lucene.Net.Documents.Field fieldID = new Field(ID_FN, myDoc.Id, Field.Store.YES, Field.Index.ANALYZED, Field.TermVector.WITH_POSITIONS_OFFSETS);
            //Lucene.Net.Documents.Field fieldAuthor = new Field(AUTHOR_FN, myDoc.Author, Field.Store.YES, Field.Index.ANALYZED, Field.TermVector.WITH_POSITIONS_OFFSETS);
            //Lucene.Net.Documents.Field fieldTitle = new Field(TITLE_FN, myDoc.Title, Field.Store.YES, Field.Index.ANALYZED, Field.TermVector.WITH_POSITIONS_OFFSETS);
            //Lucene.Net.Documents.Field fieldBibliography = new Field(BIBLIOGRAPHY_FN, myDoc.Bibliography, Field.Store.YES, Field.Index.ANALYZED, Field.TermVector.WITH_POSITIONS_OFFSETS);
            Lucene.Net.Documents.Field fieldAbstract = new Field(ABSTRACT_FN, $"{myDoc.Title} {myDoc.Abstract}", Field.Store.YES, Field.Index.ANALYZED, Field.TermVector.WITH_POSITIONS_OFFSETS);

            Lucene.Net.Documents.Document doc = new Lucene.Net.Documents.Document();
            doc.Add(fieldID);
            //doc.Add(fieldAuthor);
            //doc.Add(fieldTitle);
            //doc.Add(fieldBibliography);
            doc.Add(fieldAbstract);

            this.writer.AddDocument(doc);

            this.allDocuments.Add(myDoc.Id, myDoc);
        }

        /// <summary>
        /// Flushes buffer and closes the index
        /// </summary>
        public void CleanUpIndexer()
        {
            this.writer.Optimize();
            this.writer.Flush(true, true, true);
            this.writer.Dispose();
        }

        /// <summary>
        /// Creates searcher
        /// </summary>
        public void CreateSearcher()
        {
            this.searcher = new IndexSearcher(indexDirectory);
            this.searcher.Similarity = newSimilarity;
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
            this.parser = new QueryParser(VERSION, fieldName, analyzer);
        }

        /// <summary>
        /// Searches newly created index
        /// </summary>
        /// <param name="query">The search query</param>
        /// <returns>Ranked list of relevant documents</returns>
        public List<Journal> SearchIndex(string query)
        {
            Query q = this.parser.Parse(query);
            TopDocs td = this.searcher.Search(q, SEARCH_DOCS_NUM);

            List<Journal> docs = new List<Journal>();
            foreach (ScoreDoc sd in td.ScoreDocs)
            {
                string docId = this.searcher.Doc(sd.Doc).Get(ID_FN).ToString();
                docs.Add(this.allDocuments[docId]);
            }
            return docs;
        }

        /// <summary>
        /// Flushes search buffer and closes searcher's index
        /// </summary>
        public void CleanUpSearcher()
        {
            this.searcher.Dispose();
        }

        /// <summary>
        /// Fill the thesaurus from dictionary file
        /// </summary>
        public void InitThesaurus()
        {
            thesaurus = new Dictionary<string, List<string>>();
            string[] dictionaryFile = System.IO.File.ReadAllLines(@"Resources/Dictionaries/english.txt");
            if (stemmer == null)
                stemmer = new PorterStemmerAlgorithm.PorterStemmer();
            string stemResult = "";
            foreach (string token in dictionaryFile)
            {
                stemResult = stemmer.stemTerm(token);
                if (thesaurus.ContainsKey(stemResult))
                    thesaurus[stemResult].Add(token);
                else
                {
                    thesaurus[stemResult] = new List<string>();
                    thesaurus[stemResult].Add(token);
                }
            }
        }

        /// <summary>
        /// Get expanded query from thesaurus
        /// </summary>
        /// <param name="query">Query</param>
        /// <returns>Expanded query</returns>
        public List<string> GetExpandedQuery(string query)
        {
            if (this.stemmer == null)
            {
                this.stemmer = new PorterStemmerAlgorithm.PorterStemmer();
            }

            string stemmedQuery = stemmer.stemTerm(query);

            if (thesaurus.ContainsKey(stemmedQuery))
            {
<<<<<<< HEAD
                for (int i = 0; i < thesaurus[stemmedQuery].Count; i++)
                {
                    if (thesaurus[stemmedQuery][i] == query)
                        thesaurus[stemmedQuery][i] += "^5";
                }
=======
>>>>>>> 1ec6d82c33a56f2418bada3d9969271909983521
                return thesaurus[stemmedQuery];
            }
            else
            {
                return null;
            }
        }
        
        /// <summary>
        /// Query preprocessing
        /// </summary>
        /// <param name="query">query</param>
        /// <returns>Expanded query</returns>
        public string PreProcessQuery(string query)
        {
            string[] querySplit = query.Split(' ');
            List<string> expandedQuery = new List<string>();
            foreach (string token in querySplit)
            {
                List<string> result = this.GetExpandedQuery(token);
                if (result != null)
                {
                    expandedQuery.AddRange(result);
                }
                else
                {
                    expandedQuery.Add(token);
                }
            }
            query = String.Join(" ", expandedQuery);
            return query;
        }
    }
}
