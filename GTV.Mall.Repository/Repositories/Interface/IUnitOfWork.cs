using GTV.Mall.Models.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GTV.Mall.Repository.Repositories.Interface
{
    public interface IUnitOfWork
    {
        IRepository<Category, Guid> CategoryRepository { get; }

        #region Account
        IRepository<Product, Guid> ProductRepository { get; }
        IRepository<ProductAddon, Guid> ProductAddonRepository { get; }

        //IRepository<Entity, Guid> EntityRepository { get; }
        IRepository<ProductDelivery, Guid> ProductDeliveryRepository { get; }
        IRepository<ProductDiscount, Guid> ProductDiscountRepository { get; }
        IRepository<ProductMedia, Guid> ProductMediaRepository { get; }
        IRepository<ProductPayment, Guid> ProductPaymentRepository { get; }
        IRepository<ProductRecycle, Guid> ProductRecycleRepository { get; }
        IRepository<ProductTag, Guid> ProductTagRepository { get; }
        IRepository<PromoCode, Guid> PromoCodeRepository { get; }
        #endregion

        #region Account
        IRepository<Member, Guid> MemberRepository { get; }
        #endregion

        int SaveChanges();

    }
}
