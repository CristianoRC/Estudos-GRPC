# Protobuf- Protocol Buffers

Uma forma de estruturar e trabalhar com dados binários de forma simples.

Em um arquivo .protobuf temos as regras, o contrato, que sera usado para fazer chamadas entre os serviços. Nesse arquivo temos algumas informações.

## Mensagens

Mensagens("objetos"), é a forma que o Protobuf usa para representar os tipos de entradas e saídas dos services.

1. Nome da propriedade
1. [Tipos de dados](./Types.md)
    1. [Enum](./Enum.md)
1. Posição das propriedades
1. Se é opicional ou não
1. Você pode configurar os namespaces(package)

Ex.:

``` protobuf
package services.hello;

message HelloRequest {
  string name = 1;
}

message HelloReply {
  string message = 1;
  string name = 2;
}
```

### Importação de definições

Você pode usar outros tipos de mensagens já prontas, como se fosse um pacote Nuget ou NPM com algumas mensagens genéricas.

Um exemplo é o trabalho com datas, onde a gente pode importar os tipos(mensagens) criadas pelo google

Ex.:

```protobuf
syntax = "proto3"

import "google/protobuf/duration.proto";  
import "google/protobuf/timestamp.proto";

message Meeting {
    string subject = 1;
    google.protobuf.Timestamp start = 2;
    google.protobuf.Duration duration = 3;
}  
```
Exemplo retirado da docuemntação da Microsoft.

## Serviços

---

É um protocolo criado pelo Google para trafegar estruturas de dados de forma extensível e otimizada entre diferentes aplicações, sendo uma alternativa ao uso de serialização de dados em JSON, XML e similares. - [Lambda3](https://www.lambda3.com.br/2018/12/protobuf-uma-alternativa-a-serializacao-em-json-e-xml/)
