using Xunit;

namespace abp.BookStore.MongoDB;

[CollectionDefinition(BookStoreTestConsts.CollectionDefinitionName)]
public class BookStoreMongoCollection : BookStoreMongoDbCollectionFixtureBase
{

}
