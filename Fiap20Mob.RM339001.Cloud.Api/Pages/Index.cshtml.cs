using Amazon.DynamoDBv2;
using Amazon.DynamoDBv2.DataModel;
using Amazon.DynamoDBv2.DocumentModel;
using Amazon.DynamoDBv2.Model;
using Amazon.Runtime;
using Fiap20Mob.RM339001.Cloud.Api.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fiap20Mob.RM339001.Cloud.Api.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly IAmazonDynamoDB _amazonDynamoDB;

        [BindProperty]
        public Pessoa Pessoa { get; set; }
        public List<Pessoa> ListaPessoas { get; set; }

        public IndexModel(ILogger<IndexModel> logger,
            IAmazonDynamoDB amazonDynamoDB)
        {
            _logger = logger;
            _amazonDynamoDB = amazonDynamoDB;
            ListaPessoas = new List<Pessoa>();
        }

        public async Task OnGet()
        {
            await ListarPessoas();
        }

        public void OnPost()
        {
            Pessoa.Id = ListaPessoas.Count + 1;
            ListaPessoas.Add(Pessoa);
            Pessoa = new Pessoa();
            ViewData["ListaPessoas"] = ListaPessoas;
        }

        private async Task ListarPessoas()
        {

            try
            {
                
                ListaPessoas = new List<Pessoa>();

                //var table = Table.LoadTable(_amazonDynamoDB, "Pessoas");
                //var docs = await table.Scan(new ScanFilter()).GetRemainingAsync();

                //foreach (var item in docs)
                //{
                //    ListaPessoas.Add(new Pessoa
                //    {
                //        Id = (int)item["Id"].AsInt(),
                //        Idade = item["Idade"].AsInt(),
                //        Nome = item["Nome"].AsString(),
                //        Sobrenome = item["Sobrenome"].AsString()
                //    });
                //}

                ViewData["ListaPessoas"] = ListaPessoas;
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}
