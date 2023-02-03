using abp.BookStore.MongoDB;
using Volo.Abp.Modularity;

namespace abp.BookStore;

[DependsOn(
    typeof(BookStoreMongoDbTestModule)
    )]
public class BookStoreDomainTestModule : AbpModule
{

}
