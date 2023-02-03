using abp.BookStore.MongoDB;
using Xunit;

namespace abp.BookStore;

[CollectionDefinition(BookStoreTestConsts.CollectionDefinitionName)]
public class BookStoreApplicationCollection : BookStoreMongoDbCollectionFixtureBase
{

}
