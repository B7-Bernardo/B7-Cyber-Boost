
# ⚙️ Important Note — B7 Cyber Boost

### 📘 Análise dos Comandos Removidos no Windows 10 e 11 25h2 

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
  → Todos os comandos listados foram removidos por **obsolescência total** ou **falta de suporte nativo**.

* 🔹 **Windows 10 (21H2 / 22H2):**
  → A maioria dos comandos ainda pode ser aceita, mas são **inócuos** e **sem ganho real de performance**.

> ✅ **Resultado Final:**
> O script do **B7 Cyber Boost** permanece seguro, limpo e compatível com as versões modernas do Windows, evitando erros de log e mantendo otimizações realmente eficazes.

---

**📅 Última atualização:** 07/10/2025
**👤 Autor:** Bernardo (B7)
**🔗 Projeto:** [B7 Cyber Boost](https://github.com/B7-Bernardo/B7-Cyber-Boost)

