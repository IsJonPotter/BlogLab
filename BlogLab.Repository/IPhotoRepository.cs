using System.Threading.Tasks;
using BlogLab.Models.Photo;

namespace BlogLab.Repository
{
    public interface IPhotoRepository
    {
         public Task<Photo> InsertAsync(PhotoCreate photoCreate, int applicationUserId);
         public Task<Photo> GetAsync(int photoId);
         public Task<Photo> GetAllByUserIdAsync(int applicationUserId);
         public Task<Photo> DeleteAsync(int photoId);
    }
}