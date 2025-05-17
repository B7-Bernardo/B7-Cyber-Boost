---

## ⚙️ **Configurações do Windows – Guia B7 Cyber Boost**

### 🧠 Configurações Inteligentes Automatizadas
Todas as otimizações são aplicadas automaticamente, sem que você precise configurar manualmente cada item.

O programa analisa as características do seu sistema — como quantidade de memória RAM, modelo da placa de vídeo, tipo de processador, entre outros — e, com base nesses dados, seleciona e aplica os ajustes mais adequados.

✅ Basta clicar no botão da configuração desejada e o sistema escolhe automaticamente os melhores parâmetros para o seu PC.

---

## 🔻 Desativação de Tarefas (Serviços)

### 🎯 Objetivo:

Melhorar o desempenho geral desativando serviços do Windows considerados desnecessários para a maioria dos usuários.

### 📋 Serviços sugeridos para desativação:

| Serviço                                    | Função                                                                  |
| ------------------------------------------ | ----------------------------------------------------------------------- |
| `diagnosticshub.standardcollector.service` | Coleta dados de diagnóstico do sistema.                                 |
| `DiagTrack`                                | Telemetria e rastreamento de uso.                                       |
| `dmwappushservice`                         | Suporte a mensagens push da Microsoft.                                  |
| `lfsvc`                                    | Serviço de geolocalização.                                              |
| `MapsBroker`                               | Gerencia mapas offline.                                                 |
| `NetTcpPortSharing`                        | Compartilhamento de portas TCP.                                         |
| `RemoteAccess`                             | Suporte a conexões VPN e de acesso remoto.                              |
| `RemoteRegistry`                           | Permite edição remota do Registro do Windows.                           |
| `SharedAccess`                             | Compartilhamento de conexão com a internet.                             |
| `WbioSrvc`                                 | Suporte a autenticação biométrica.                                      |
| `WMPNetworkSvc`                            | Compartilhamento de mídia com outros dispositivos na rede.              |
| `XblAuthManager`                           | Autenticação de Xbox Live.                                              |
| `XblGameSave`                              | Sincronização de saves do Xbox.                                         |
| `XboxNetApiSvc`                            | Rede do Xbox Live.                                                      |
| `ndu`                                      | Monitor de uso de dados de rede.                                        |
| `SysMain` *(Superfetch)*                   | Pré-carregamento de aplicativos na RAM. Potencial risco de segurança.   |
| `TeamViewer`                               | Controle remoto. Pode rodar em segundo plano e conter vulnerabilidades. |

### ⚠️ Por que desativar *TeamViewer*?

* **Segurança:** Histórico de falhas de segurança.
* **Desempenho:** Pode consumir CPU/RAM mesmo inativo.
* **Privacidade:** Impede conexões remotas não autorizadas.

### ⚠️ Por que desativar *SysMain*?

* **Privacidade/Security:** Já foi associado a reinstalação de malwares (*Fonte: Kaspersky*).
* **Performance:** Em máquinas com SSD, o ganho de performance é questionável.

---

## 🎮 Desativar Game Bar

### 🧩 Motivos para desativar a Game Bar:

* **Performance:** Pode causar travamentos ou quedas de FPS.
* **Compatibilidade:** Conflita com gravadores/capturadores de terceiros.
* **Otimização:** Libera recursos do sistema.
* **Estabilidade:** Testes mostraram redução de bugs e travamentos em jogos.

**✅ Recomenda-se desativar se não for usada ativamente.**

---

## 📉 Desativar Telemetria

### 📌 O que é e por que desativar:

* **Uso de recursos:** Alguns processos de telemetria consomem CPU e disco.
* **Privacidade:** Limita o envio de dados de uso e sistema à Microsoft.
* **Desempenho:** Reduz processos em segundo plano.

> ℹ️ *Nota:* A telemetria também oferece benefícios, como melhoria do sistema baseada em dados reais. A proposta aqui é otimizar sem eliminar totalmente.

**🛠️ A função do B7 Cyber Boost aplica ajustes equilibrados para desempenho e privacidade.**

---

## 🚀 Otimizações de Desempenho

### 🔧 O que inclui:

* **Ajustes finos no sistema operacional.**
* **Aplicação de comandos avançados para apoiadores.**
* **Foco em fluidez e estabilidade.**

Explore essas opções para turbinar a responsividade geral do Windows.

---

## 🧠 Redução de Latência (Parte 1 e 2)

### 🎯 Benefícios:

* **Menor tempo de resposta geral.**
* **Ideal para gamers, produtores de áudio e usuários exigentes.**
* **Comandos extras disponíveis para apoiadores, com documentação explicativa.**

**Use esta função para garantir performance máxima em tarefas sensíveis à latência.**

---

## ⚡ Menu Mais Rápido

### 🪄 Otimize a navegação no Windows:

* **Remoção de atrasos em menus e animações.**
* **Acelera abertura de menus, Explorer e até HUDs de jogos.**

### 🛠️ Ajustes aplicados:

1. **Remover atraso do menu:**

   ```csharp
   Registry.SetValue("HKEY_CURRENT_USER\\Control Panel\\Desktop", "MenuShowDelay", "0");
   ```
2. **Desativar animações do sistema:**

   ```csharp
   Registry.SetValue("HKEY_CURRENT_USER\\Control Panel\\Desktop", "DragFullWindows", "0");
   Registry.SetValue("HKEY_CURRENT_USER\\Control Panel\\Desktop", "UserPreferencesMask", "0");
   ```

> ✨ *Outros ajustes avançados são aplicados automaticamente para apoiadores.*

---

## 🧠 CPU Core Parking

### 🔍 O que é?

O *Core Parking* desativa núcleos ociosos da CPU para economizar energia, mas isso pode causar:

* **Perda de performance em jogos.**
* **Engasgos em softwares de alta demanda.**

### 🛠️ O que o B7 Cyber Boost faz:

* Ajusta o plano de energia para evitar o *core parking*.
* Garante que todos os núcleos fiquem ativos sob carga.
* Permite maior controle para usuários avançados (opcional).

---

## 🔧 Windows Update

 ###  Windows Update no B7 Cyber Boost:
🔍 Esta função do B7 Cyber Boost **não desativa** as atualizações do Windows, que são essenciais para a segurança e o bom funcionamento do sistema.

* **Remove Otimização de Entrega:** Desativa o compartilhamento de atualizações com outros computadores na rede, evitando riscos de segurança em caso de infecção.
* **Bloqueia notificações:** Impede o aparecimento da mensagem "Atualizações disponíveis".

Em resumo, a função Windows Update do B7 Cyber Boost foca na segurança e em evitar interrupções, mantendo seu sistema atualizado diretamente pela Microsoft e sem notificações incômodas.

---

