# ⚙️ Important Note — B7 Cyber Boost

### 📘 Análise dos Comandos Removidos no Windows 10 e 11 (24H2 / 25H2)

> **Contexto:**
> Este documento detalha as alterações aplicadas ao **B7 Cyber Boost**, especificamente os **comandos `bcdedit` removidos ou descontinuados** nas versões modernas do Windows 10 e 11.
> O objetivo é garantir **compatibilidade total**, **execução limpa (sem erros de log)** e **máxima estabilidade** em builds recentes (24H2 / 25H2).

---

## 🧠 Análise dos Comandos Removidos — Windows 11 (24H2 / 25H2)

| Comando                                       | Status         | Motivo / Explicação                                                                     |
| --------------------------------------------- | -------------- | --------------------------------------------------------------------------------------- |
| `bcdedit /set vm Yes`                         | ❌ Removido     | Parâmetro de virtualização obsoleto; substituído por mecanismos automáticos do Hyper-V. |
| `bcdedit /set vsmlaunchtype Auto`             | ❌ Removido     | VSM agora é gerenciado automaticamente; comando não reconhecido.                        |
| `bcdedit /deletevalue isolatedcontext`        | ❌ Removido     | Substituído por segurança baseada em virtualização (VBS).                               |
| `bcdedit /deletevalue MSI`                    | ❌ Removido     | Configuração MSI descontinuada; sem efeito em builds modernas.                          |
| `bcdedit /deletevalue usefirmwarepcisettings` | ❌ Removido     | Obsoleto em sistemas UEFI; Windows controla automaticamente PCI.                        |
| `bcdedit /deletevalue x2apicpolicy`           | ❌ Removido     | Parâmetro APIC antigo; ignorado em CPUs modernas.                                       |
| `bcdedit /set linearaddress57 OptOut`         | ❌ Removido     | Experimental; não mais suportado.                                                       |
| `bcdedit /set allowedinmemorysettings 0x0`    | ❌ Removido     | Obsoleto; gerenciamento de memória é automático.                                        |
| `bcdedit /set usephysicaldestination No`      | ❌ Removido     | Sem efeito em builds modernas.                                                          |
| `bcdedit /set tscsyncpolicy Legacy input`     | ⚙️ Substituído | Agora é usado `tscsyncpolicy Enhanced` — melhor sincronização de TSC.                   |

**💡 Observações:**

* Evita erros de log: `"The element data type specified is not recognized"`.
* Mantém apenas parâmetros eficazes e compatíveis (`disabledynamictick`, `useplatformtick`, `tscsyncpolicy Enhanced`, etc.).
* Garante performance otimizada e estabilidade em jogos e apps sensíveis à latência.

---

## 💾 Análise dos Comandos Removidos — Windows 10 (21H2 / 22H2)

| Comando                                       | Status          | Descrição / Observações                              | Recomendação        |
| --------------------------------------------- | --------------- | ---------------------------------------------------- | ------------------- |
| `bcdedit /set vm Yes`                         | ⚠️ Obsoleto     | Ainda aceito em versões antigas; sem efeito prático. | 🚫 Não reintegrar   |
| `bcdedit /set vsmlaunchtype Auto`             | ⚠️ Obsoleto     | VSM é gerenciado dinamicamente.                      | 🚫 Não reintegrar   |
| `bcdedit /deletevalue isolatedcontext`        | ⚙️ Funcional    | Aceito, porém irrelevante em builds recentes.        | 🚫 Não reintegrar   |
| `bcdedit /deletevalue MSI`                    | ⚙️ Funcional    | Sem impacto em hardware moderno.                     | 🚫 Não reintegrar   |
| `bcdedit /deletevalue usefirmwarepcisettings` | ⚙️ Funcional    | Ignorado em sistemas UEFI.                           | 🚫 Não reintegrar   |
| `bcdedit /deletevalue x2apicpolicy`           | ⚙️ Funcional    | Ignorado em CPUs modernas.                           | 🚫 Não reintegrar   |
| `bcdedit /set linearaddress57 OptOut`         | ❌ Não suportado | Comando experimental, gera erro.                     | 🚫 Não reintegrar   |
| `bcdedit /set allowedinmemorysettings 0x0`    | ❌ Obsoleto      | Sem efeito prático.                                  | 🚫 Não reintegrar   |
| `bcdedit /set usephysicaldestination No`      | ⚙️ Funcional    | Aceito, porém irrelevante.                           | 🚫 Não reintegrar   |
| `bcdedit /set tscsyncpolicy Legacy input`     | ⚙️ Funcional    | “Legacy” ainda suportado, mas inferior a “Enhanced”. | ✅ Manter `Enhanced` |

---

## 🧩 Conclusão Técnica

* 🔹 **Windows 11 (24H2 / 25H2):**
  Todos os comandos listados foram removidos por **obsolescência total** ou **falta de suporte nativo**.

* 🔹 **Windows 10 (21H2 / 22H2):**
  A maioria dos comandos ainda pode ser aceita, mas são **inócuos** e **sem ganho real de performance**.

> ✅ **Resultado Final:**
> O script do **B7 Cyber Boost** permanece **seguro, limpo e compatível** com as versões modernas do Windows, evitando erros e mantendo **otimizações eficazes**.

---

## ⚡ Observação Importante — Windows 11 25H2

> O Windows 11 25H2 introduziu o **Energy Efficiency Scheduler**, um novo modo híbrido de gerenciamento de energia e threads.
> Essas configurações têm efeito pleno apenas quando o plano de energia ativo é **"Alto Desempenho"** ou **"Ultimate Performance"**.

**Comandos recomendados:**

```cmd
powercfg -duplicatescheme e9a42b02-d5df-448d-aa00-03f14749eb61
powercfg -setactive e9a42b02-d5df-448d-aa00-03f14749eb61
```

---

## 🧠 Análise da Versão 25H2 do Windows 11 (Atualização 2025)

A atualização 25H2 é uma versão de **ciclo longo**, com foco em **estabilidade**, **IA integrada** e **refinamentos no desempenho**.
Ela sucede a 24H2 e está alinhada ao **Windows Server 2025**.

### ⚙️ Principais Melhorias

* Kernel **26100+** com agendamento otimizado de threads em CPUs híbridas (Intel 12ª gen / Ryzen 7000+).
* Melhor gerenciamento de GPU com **DirectX 12 Ultimate**.
* Integração com **Windows Copilot+** e **Recall** (desativáveis para performance máxima).
* Pilha **TCP/IP** aprimorada — menor latência e melhor desempenho em rede.
* **Win32 App Isolation** para maior segurança, com leve impacto em processos pesados.
* Novo sistema de **energia dinâmica**, ajustando clock e prioridade conforme o uso.

---

### 🧠 1. Desative Recursos de IA (para Desempenho Máximo)

Esses serviços podem ser desativados via **Registro** ou **PowerShell**:

```cmd
reg add "HKLM\SOFTWARE\Microsoft\PolicyManager\current\device\Experience" /v AllowCopilot /t REG_DWORD /d 0 /f
reg add "HKLM\SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\Advanced" /v ShowCopilotButton /t REG_DWORD /d 0 /f
```

---

### ⚡ 2. Ajuste o Plano de Energia

Ative o **Ultimate Performance** para liberar o potencial total da CPU e GPU:

```cmd
powercfg -duplicatescheme e9a42b02-d5df-448d-aa00-03f14749eb61
powercfg -setactive e9a42b02-d5df-448d-aa00-03f14749eb61
```
Análise da Detecção

Método Usado: Baseado em Environment.OSVersion.Version.Build (via RtlGetVersion API, que é confiável em .NET).

Windows 10: Build < 22000 (ex.: 19045 para 22H2).
Windows 11: Build >= 22000 (ex.: 26100 para 24H2; 26200 para 25H2).


Vantagens: Simples, sem dependências externas, funciona em .NET Framework/Core. Não usa systeminfo (lento) ou NuGet (desnecessário aqui).
Limitações: Em alguns cenários de compatibilidade, pode precisar de SetProcessDpiAwarenessContext para precisão, mas para isso basta.
Lógica: Se Win11 (>= 22000), usa valor 3 (novo comportamento); senão (Win10 ou legado), usa 2. O resto do código (máscara, sincronização, Explorer) é comum.

no Windows 11 (a partir da versão 24H2 e especialmente 25H2), a chave

HKCU\Software\Microsoft\Windows\CurrentVersion\Explorer\VisualEffects\VisualFXSetting


não é mais o controle mestre do modo “Ajustar para melhor aparência / desempenho / personalizar”.
Ela é apenas informativa — o sistema agora lê e grava a preferência visual principal em outro local, especificamente:

HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced


e na máscara binária:

HKEY_CURRENT_USER\Control Panel\Desktop\UserPreferencesMask


Portanto:

Definir apenas VisualFXSetting = 2 não altera o modo para “Personalizar”; o painel “Opções de Desempenho” continuará exibindo “Ajustar para melhor desempenho”.

O Windows 11 usa lógica combinada — ele recalcula o estado visual com base nos bits da UserPreferencesMask e ignora o valor de VisualFXSetting se houver inconsistência.

Se o registro for limpo e recriado (como no seu código), o Windows tende a recriar VisualFXSetting = 1 (melhor desempenho) na próxima inicialização do Explorer.

✅ Solução recomendada:

Após definir suas preferências visuais (bits específicos na UserPreferencesMask), defina também VisualFXSetting = 3, não 2.
O valor 3 é o que o Windows interpreta como “Let Windows choose / Custom” nas versões mais recentes.

---

**📅 Última atualização:** 07/10/2025
**👤 Autor:** Bernardo (B7)
**🔗 Projeto:** [B7 Cyber Boost](https://github.com/B7-Bernardo/B7-Cyber-Boost)
