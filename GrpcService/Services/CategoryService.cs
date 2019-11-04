using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Google.Protobuf.WellKnownTypes;
using Grpc.Core;
using GrpcService.Logger;
using static GrpcService.CategoryGreeter;

namespace GrpcService.Services
{
    public class CategoryService : CategoryGreeterBase
    {
        List<Category> modelList = new List<Category>();
        ILogger _logger = new TextLogger();

        public CategoryService()
        {
            for (int i = 0; i < 10; i++)
            {
                Category model = new Category();
                model.Id = i;
                model.Name = i + " isim";
                modelList.Add(model);
            }

        }

        public override Task<Category> Get(CategoryId request, ServerCallContext context)
        {
            _logger.Log("GET", "GET id : " + request.Id.ToString());
            Category category = new Category();
            var model = modelList.Where(x => x.Id == request.Id).FirstOrDefault();
            category = model;

            return Task.FromResult(category);
        }

        public override Task<Empty> Insert(Category request, ServerCallContext context)
        {
            _logger.Log("Insert", "Insert id : " + request.Id.ToString() + " name :" + request.Name);
            Empty response = new Empty();
            modelList.Add(new Category { Id = request.Id, Name = request.Name });
            return Task.FromResult(response);
        }

        public override Task<CategoryList> List(Empty request, ServerCallContext context)
        {

            CategoryList res = new CategoryList();
            res.Category.AddRange(modelList);
            _logger.Log("List", "List Count :" + modelList.Count());
            return Task.FromResult(res);
        }
    }
}
