
namespace ClassLibrary.Models
{
    public interface IModel
    {
        public string FileName { get; set; }
        public void Load();
        public void Save();
    }
}
