using System;
using System.Collections.Generic;
using System.Linq;
using System.Printing;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace BookCenter.Models;


public class BookModel
{
    [JsonPropertyName("total_results")]
    public int TotalResults { get; set; }

    [JsonPropertyName("total_pages")]
    public int TotalPages { get; set; }

    [JsonPropertyName("results")]
    public Result[] Results { get; set; }
}

public class Result : IData
{
    [JsonPropertyName("subcategories")]
    public string[] Subcategories { get; set; }

    [JsonPropertyName("english_language_learner")]
    public bool EnglishLanguageLearner { get; set; }

    [JsonPropertyName("vocab_words")]
    public string[] VocabWords { get; set; }

    [JsonPropertyName("page_count")]
    public int PageCount { get; set; }

    [JsonPropertyName("title_search")]
    public string TitleSearch { get; set; }

    [JsonPropertyName("author_first_names")]
    public string[] AuthorFirstNames { get; set; }

    [JsonPropertyName("max_age")]
    public int MaxAge { get; set; }

    [JsonPropertyName("canonical_published_work_id")]
    public int CanonicalPublishedWorkId { get; set; }

    [JsonPropertyName("copyright")]
    public int Copyright { get; set; }

    [JsonPropertyName("title")]
    public string Title { get; set; }

    [JsonPropertyName("measurements")]
    public Measurements Measurements { get; set; }

    [JsonPropertyName("subject_tags")]
    public string[] SubjectTags { get; set; }

    [JsonPropertyName("chapter_measurements")]
    public ChapterMeasurements[] ChapterMeasurements { get; set; }

    [JsonPropertyName("recommended_isbns")]
    public string[] RecommendedIsbns { get; set; }

    [JsonPropertyName("published_works")]
    public PublishedWorks[] PublishedWorks { get; set; }

    [JsonPropertyName("author_last_names")]
    public string[] AuthorLastNames { get; set; }

    [JsonPropertyName("series_name")]
    public string SeriesName { get; set; }

    [JsonPropertyName("min_age")]
    public int MinAge { get; set; }

    [JsonPropertyName("book_type")]
    public string BookType { get; set; }

    [JsonPropertyName("awards")]
    public object[] Awards { get; set; }

    [JsonPropertyName("authors")]
    public string[] Authors { get; set; }

    [JsonPropertyName("categories")]
    public string[] Categories { get; set; }

    [JsonPropertyName("language")]
    public string Language { get; set; }

    [JsonPropertyName("summary")]
    public string Summary { get; set; }

    [JsonPropertyName("work_id")]
    public int WorkId { get; set; }

    [JsonPropertyName("canonical_isbn")]
    public string CanonicalIsbn { get; set; }

    public override string ToString()
    {
        return $"{SeriesName}";
    }
}

public class Measurements
{
    [JsonPropertyName("english")]
    public English English { get; set; }
}

public class English
{
    [JsonPropertyName("mlf")]
    public float Mlf { get; set; }

    [JsonPropertyName("syntactic_demand_percentile")]
    public int? SyntacticDemandPercentile { get; set; }

    [JsonPropertyName("semantic_demand_percentile")]
    public int? SemanticDemandPercentile { get; set; }

    [JsonPropertyName("lexile_code")]
    public string LexileCode { get; set; }

    [JsonPropertyName("decoding_demand_percentile")]
    public int? DecodingDemandPercentile { get; set; }

    [JsonPropertyName("measurable")]
    public bool Measurable { get; set; }

    [JsonPropertyName("msl")]
    public float Msl { get; set; }

    [JsonPropertyName("lexile")]
    public int Lexile { get; set; }

    [JsonPropertyName("structure_demand_percentile")]
    public int? StructureDemandPercentile { get; set; }
}

public class ChapterMeasurements
{
    [JsonPropertyName("vocab_words")]
    public string[] VocabWords { get; set; }

    [JsonPropertyName("lexile")]
    public int Lexile { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("number")]
    public int Number { get; set; }
}

public class PublishedWorks
{
    [JsonPropertyName("isbn")]
    public string Isbn { get; set; }

    [JsonPropertyName("english_language_learner")]
    public bool EnglishLanguageLearner { get; set; }

    [JsonPropertyName("copyright")]
    public int Copyright { get; set; }

    [JsonPropertyName("published_work_id")]
    public int PublishedWorkId { get; set; }

    [JsonPropertyName("page_count")]
    public int PageCount { get; set; }

    [JsonPropertyName("binding")]
    public string Binding { get; set; }

    [JsonPropertyName("cover_art_url")]
    public string CoverArtUrl { get; set; }
}