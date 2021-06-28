using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using Business.Abstract;
using Business.Concrete;
using Core.Utilities.security.Jwt;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;

namespace Business.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule:Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<ProductService>().As<IProductService>();
            builder.RegisterType<EfProductDal>().As<IProductDal>();

            builder.RegisterType<EfCategoryDal>().As<ICategoryDal>();
            builder.RegisterType<CategoryService>().As<ICategoryService>();
            
            builder.RegisterType<EfUserDal>().As<IUserDal>();
            builder.RegisterType<UserService>().As<IUserService>();

            builder.RegisterType<AuthService>().As<IAuthService>();

            builder.RegisterType<JwtHelper>().As<ITokenHelper>();
        }
    }
}
