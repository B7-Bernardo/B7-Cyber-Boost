# ⚙️ B7 Cyber Boost — Nota Importante

### 📘 Compatibilidade com Windows 10/11 (24H2 / 25H2)

> Atualização sobre comandos `bcdedit` e ajustes de energia para **execução limpa**, sem erros de log, e **otimização máxima**.

---

## 🧠 Comandos `bcdedit` Removidos / Obsoletos

| Comando                                       | Status         | Observação                                                     |
| --------------------------------------------- | -------------- | -------------------------------------------------------------- |
| `bcdedit /set vm Yes`                         | ❌ Removido     | Obsoleto; virtualização gerenciada automaticamente.            |
| `bcdedit /set vsmlaunchtype Auto`             | ❌ Removido     | VSM é automático; comando ignorado.                            |
| `bcdedit /deletevalue isolatedcontext`        | ❌ Removido     | Substituído por segurança baseada em virtualização (VBS).      |
| `bcdedit /deletevalue MSI`                    | ❌ Removido     | Sem efeito em builds modernas.                                 |
| `bcdedit /deletevalue usefirmwarepcisettings` | ❌ Removido     | Obsoleto em UEFI; Windows controla automaticamente PCI.        |
| `bcdedit /deletevalue x2apicpolicy`           | ❌ Removido     | Ignorado em CPUs modernas.                                     |
| `bcdedit /set linearaddress57 OptOut`         | ❌ Removido     | Não suportado.                                                 |
| `bcdedit /set allowedinmemorysettings 0x0`    | ❌ Removido     | Sem efeito prático.                                            |
| `bcdedit /set usephysicaldestination No`      | ❌ Removido     | Ignorado.                                                      |
| `bcdedit /set tscsyncpolicy Legacy input`     | ⚙️ Substituído | Use `tscsyncpolicy Enhanced` para melhor sincronização de TSC. |

> ✅ Resultado: Builds modernas não usam mais esses comandos; script permanece seguro e limpo.

---

## ⚡ Ajustes de Energia Recomendados — Windows 11 25H2

1. **Plano de Energia Ultimate Performance**:

```cmd
powercfg -duplicatescheme e9a42b02-d5df-448d-aa00-03f14749eb61
powercfg -setactive e9a42b02-d5df-448d-aa00-03f14749eb61
```

2. **Desativar recursos de IA (Copilot/Recall)**:

```cmd
reg add "HKLM\SOFTWARE\Microsoft\PolicyManager\current\device\Experience" /v AllowCopilot /t REG_DWORD /d 0 /f
reg add "HKLM\SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\Advanced" /v ShowCopilotButton /t REG_DWORD /d 0 /f
```

3. **Configurações extras críticas**:

| Configuração                                                       | Valor           | Observação                                           |
| ------------------------------------------------------------------ | --------------- | ---------------------------------------------------- |
| Vídeo — Desligar monitor após                                      | 0               | Nunca (forçar /attributes + /setacvalueindex)        |
| Suspensão seletiva USB                                             | 0               | Desabilitado (forçar /attributes + /setacvalueindex) |
| Core Parking Minimum Cores                                         | 100             | Pode ser ignorado se max=0                           |
| Boost Mode / Energy Preference / WakeTimers / JS Timer / Away Mode | 100/100/Ativado | Aplicar conforme script                              |

> ⚠️ Problemas comuns: permissões, bugs em builds Insider (Game Bar), validação `max > 0`.

---

## 🧠 Observações Técnicas

* Windows 11 (24H2/25H2) ignora o valor `VisualFXSetting = 2`; use **3** para modo “Custom”.
* Build 25H2 introduziu **Energy Efficiency Scheduler**; efeito pleno somente com plano “Alto Desempenho” ou “Ultimate Performance”.
* Script ajustado para incluir `/attributes` e relaxar validação `max` em settings discretos.

---

**📅 Última atualização:** 07/10/2025
**👤 Autor:** Bernardo (B7)
**🔗 Projeto:** [B7 Cyber Boost](https://github.com/B7-Bernardo/B7-Cyber-Boost)

---


