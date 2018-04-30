namespace DAL
{
    using System.Data.Entity;

    public class VocabularyModel : DbContext
    {
        public VocabularyModel() : base("name=VocabularyModel")
        {
            Database.SetInitializer<VocabularyModel>(new CustomInitializer<VocabularyModel>());
        }

        public virtual DbSet<Word> Words { get; set; }
        public virtual DbSet<Credential> Credentials { get; set; }
        public virtual DbSet<Dictionary> Dictionaries { get; set; }
    }
}