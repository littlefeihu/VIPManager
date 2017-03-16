using DF.VIP.Infrastructure.Entity;
using DF.VIP.Infrastructure.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DF.VIP.AppService.Admin
{
    public class AdminService
    {
        IQueryRepository<Company> qcompany;
        ICommandRepository<Company> cmdCompany;
        IQueryRepository<LoginUser> qLoginUser;
        ICommandRepository<LoginUser> cmdLoginUser;
        public AdminService(IQueryRepository<Company> qcompany, ICommandRepository<Company> cmdCompany, IQueryRepository<LoginUser> qLoginUser, ICommandRepository<LoginUser> cmdLoginUser)
        {
            this.qcompany = qcompany;
            this.cmdCompany = cmdCompany;
            this.qLoginUser = qLoginUser;
            this.cmdLoginUser = cmdLoginUser;
        }
        public List<Company> GetAllCompany(string companyName)
        {
            return this.qcompany.Entities.Where(o => o.CompanyName.Contains(companyName)).ToList();
        }

        public void CreateCompany(Company company)
        {
            this.cmdCompany.Insert(company);
            this.cmdCompany.SaveChanges();
        }

        public Company GetCompany(int companyid)
        {
            return this.qcompany.Entities.FirstOrDefault(o => o.ID == companyid);
        }

        public List<LoginUser> GetAllUsers(string phone)
        {
            return this.qLoginUser.Entities.Where(o => o.Phone.Contains(phone)).ToList();
        }

        public void CreateUser(LoginUser user)
        {
            this.cmdLoginUser.Insert(user);
            this.cmdLoginUser.SaveChanges();
        }
    }
}
