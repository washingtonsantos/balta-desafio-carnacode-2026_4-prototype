using Prototype;
using Prototype.Document;

Console.WriteLine("=== Sistema de Templates de Documentos ===\n");

var service = new DocumentService();

Console.WriteLine("Criando 10 contratos de serviço...");
var startTime = DateTime.Now;
var contract = service.CreateServiceContract();

for (int i = 1; i <= 10; i++)
{
    var copyContract = (DocumentTemplate)contract.Clone();
    // Depois modificamos apenas dados específicos do cliente
    contract.Title = $"Contrato #{i} - Cliente {i}";

    Console.WriteLine($"{contract.Title}\n");
}

var elapsed = (DateTime.Now - startTime).TotalMilliseconds;
Console.WriteLine($"Tempo total: {elapsed}ms\n");

var consultingContract = service.CreateConsultingContract();
var clone = (DocumentTemplate)consultingContract.Clone();

// Exemplo de uso do PrototypeRegistry
var prototypeRegistry = new PrototypeRegistry();
prototypeRegistry.Register("consultingContract", consultingContract.Clone());
var consultingContractPrototype = (DocumentTemplate)prototypeRegistry.Get("consultingContract").Clone();
service.DisplayTemplate(consultingContractPrototype);