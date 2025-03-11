using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Data;
using DataAccessLayer.Repositories;
using DomainLayer.Models;
using Microsoft.AspNetCore.Identity;

namespace DataAccessLayer.UnitOfWork
{
    public class UnitOfWorkRepository : IUnitOfWorkRepository
    {
        private readonly ApplicationDbContext _applicationDbContext;
        private readonly UserManager<User> _userManager;
        private readonly RoleManager<Role> _roleManager;

        public UnitOfWorkRepository(ApplicationDbContext applicationDbContext, RoleManager<Role> roleManager, UserManager<User> userManager)
        {
            _applicationDbContext = applicationDbContext;
            _roleManager = roleManager;
            _userManager = userManager;
        }

        private CategoryRepository _categoryRepository;
        private CommentRepository _commentRepository;
        private LikeRepository _likeRepository;
        private PostRepository _postRepository;
        private UserRepository _userRepository;
        private RoleRepository _roleRepository;

        public CategoryRepository categoryRepository => _categoryRepository ??=  new CategoryRepository(_applicationDbContext);

        public CommentRepository commentRepository => _commentRepository ??= new CommentRepository(_applicationDbContext);

        public LikeRepository likeRepository => _likeRepository ??= new LikeRepository(_applicationDbContext);

        public PostRepository postRepository => _postRepository ??= new PostRepository(_applicationDbContext);

        public UserRepository userRepository => _userRepository ??= new UserRepository(_userManager);

        public RoleRepository roleRepository => _roleRepository ??= new RoleRepository(_roleManager);
    }
}
