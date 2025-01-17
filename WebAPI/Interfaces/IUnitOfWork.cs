using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using demo_english_school.Interfaces;

namespace WebAPI.Interfaces;

public interface IUnitOfWork
{
    IUserRepository UserRepository { get; }

    ITeacherRepository TeacherRepository { get; }

    IStudentRepository StudentRepository { get; }

    IAdminRepository AdminRepository { get; }

    Task SaveAsync();
}
