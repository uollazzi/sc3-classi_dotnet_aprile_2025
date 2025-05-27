using sc3_classi.Models;

namespace sc3_classi;

public interface ICommentabile
{
    public List<Commento> Commenti { get; set; }
}