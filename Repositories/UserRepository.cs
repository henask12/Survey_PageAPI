using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Survey.Interfaces;
using Survey.Models;

namespace Survey.Repositories
{
    public class UserRepository : IRepository<User>
    {
        private readonly YourDbContext _context;

    public UserRepository(YourDbContext context)
    {
        _context = context;
    }

    public IEnumerable<User> GetAll()
    {
        return _context.Users.ToList();
    }

    public User GetById(int id)
    {
        return _context.Users.FirstOrDefault(u => u.Id == id);
    }

    public void Add(User entity)
    {
        _context.Users.Add(entity);
        _context.SaveChanges();
    }

    public void Update(User entity)
    {
        _context.Users.Update(entity);
        _context.SaveChanges();
    }

    public void Delete(int id)
    {
        var user = _context.Users.FirstOrDefault(u => u.Id == id);
        if (user != null)
        {
            _context.Users.Remove(user);
            _context.SaveChanges();
        }
    }
    }
}