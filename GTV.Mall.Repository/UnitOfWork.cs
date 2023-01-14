using GTV.Mall.Models.DataModel;
using GTV.Mall.Repository.Data;
using GTV.Mall.Repository.Repositories;
using GTV.Mall.Repository.Repositories.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GTV.Mall.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private ApplicationDbContext _context;
        public IRepository<Category, Guid> CategoryRepository { get; private set; }

        public IRepository<Product, Guid> ProductRepository { get; private set; }

        public IRepository<ProductAddon, Guid> ProductAddonRepository { get; private set; }

        public IRepository<ProductDelivery, Guid> ProductDeliveryRepository { get; private set; }

        public IRepository<ProductDiscount, Guid> ProductDiscountRepository { get; private set; }

        public IRepository<ProductMedia, Guid> ProductMediaRepository { get; private set; }

        public IRepository<ProductPayment, Guid> ProductPaymentRepository { get; private set; }

        public IRepository<ProductRecycle, Guid> ProductRecycleRepository { get; private set; }

        public IRepository<ProductTag, Guid> ProductTagRepository { get; private set; }

        public IRepository<PromoCode, Guid> PromoCodeRepository { get; private set; }

        public IRepository<Member, Guid> MemberRepository { get; private set; }
        public ApplicationUserRepository ApplicationUserRepository { get; private set; }

        //public UnitOfWork(string connectionString) {
        //    DbContextOptions<ApplicationDbContext> options;
        //    options.use
        //    _context = new ApplicationDbContext(connectionString);
        //    this.InitRepositories();

        //}

        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
            InitRepositories();
        }

        private void InitRepositories()
        {
            CategoryRepository = new Repository<Category, Guid>(_context);
            ProductRepository = new Repository<Product, Guid>(_context);

            ProductAddonRepository = new Repository<ProductAddon, Guid>(_context);

            ProductDeliveryRepository = new Repository<ProductDelivery, Guid>(_context);

            ProductDiscountRepository = new Repository<ProductDiscount, Guid>(_context);

            ProductMediaRepository = new Repository<ProductMedia, Guid>(_context);

            ProductPaymentRepository = new Repository<ProductPayment, Guid>(_context);

            ProductRecycleRepository = new Repository<ProductRecycle, Guid>(_context);

            ProductTagRepository = new Repository<ProductTag, Guid>(_context);

            PromoCodeRepository = new Repository<PromoCode, Guid>(_context);

            MemberRepository = new Repository<Member, Guid>(_context);

            ApplicationUserRepository = new ApplicationUserRepository(_context);
        }

        /// <summary>
        /// Commit all changes
        /// </summary>
        public virtual int SaveChanges()
        {
            return _context.SaveChanges();
        }
    }
}
