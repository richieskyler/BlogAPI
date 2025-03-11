using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Repositories;

namespace DataAccessLayer.UnitOfWork
{
    public interface IUnitOfWorkRepository
    {
        CategoryRepository categoryRepository { get; }
        CommentRepository commentRepository { get; }
        LikeRepository likeRepository { get; }
        PostRepository postRepository { get; }
        UserRepository userRepository { get; }
        RoleRepository roleRepository { get; }

    }
}
