
---

# ⚙️ **B7 Cyber Boost — Nota Importante**

### 📘 **Compatibilidade Confirmada**

**Windows 10 e 11 — Builds 24H2 / 25H2**

> Esta atualização refina os comandos `bcdedit` e os ajustes de energia para garantir **execução limpa**, **sem erros de log**, e **máximo desempenho em builds modernas** do Windows.

---

## 🧠 **Comandos `bcdedit` Removidos, Obsoletos ou Substituídos**

| Comando                                       | Status         | Observação Técnica                                                 |
| --------------------------------------------- | -------------- | ------------------------------------------------------------------ |
| `bcdedit /set vm Yes`                         | ❌ Removido     | Virtualização agora gerenciada automaticamente.                    |
| `bcdedit /set vsmlaunchtype Auto`             | ❌ Removido     | O VSM é inicializado de forma nativa; comando ignorado.            |
| `bcdedit /deletevalue isolatedcontext`        | ❌ Removido     | Substituído por novos mecanismos de segurança baseados em VBS.     |
| `bcdedit /deletevalue MSI`                    | ❌ Removido     | Sem efeito em builds atuais.                                       |
| `bcdedit /deletevalue usefirmwarepcisettings` | ❌ Removido     | Obsoleto em sistemas UEFI; controle automatizado pelo Windows.     |
| `bcdedit /deletevalue x2apicpolicy`           | ❌ Removido     | Ignorado em CPUs modernas.                                         |
| `bcdedit /set linearaddress57 OptOut`         | ❌ Removido     | Não suportado em builds recentes.                                  |
| `bcdedit /set allowedinmemorysettings 0x0`    | ❌ Removido     | Sem impacto funcional.                                             |
| `bcdedit /set usephysicaldestination No`      | ❌ Removido     | Comando depreciado e inefetivo.                                    |
| `bcdedit /set tscsyncpolicy Legacy input`     | ⚙️ Substituído | Use `tscsyncpolicy Enhanced` para sincronização de TSC aprimorada. |

> ✅ **Resultado:** scripts compatíveis com builds modernas, execução estável e sem resíduos de parâmetros depreciados.

---

## ⚡ **Ajustes de Energia Recomendados — Windows 11 (25H2)**

### 1️⃣ **Ativar o Plano de Energia “Desempenho Máximo”**

```cmd
powercfg -duplicatescheme e9a42b02-d5df-448d-aa00-03f14749eb61
powercfg -setactive e9a42b02-d5df-448d-aa00-03f14749eb61
```

---

### 2️⃣ **Desativar Recursos de IA (Copilot / Recall)**

```cmd
reg add "HKLM\SOFTWARE\Microsoft\PolicyManager\current\device\Experience" /v AllowCopilot /t REG_DWORD /d 0 /f
reg add "HKLM\SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\Advanced" /v ShowCopilotButton /t REG_DWORD /d 0 /f
```

---

### 3️⃣ **Configurações Avançadas de Energia**

| Configuração                                                      | Valor         | Descrição Técnica                                |
| ----------------------------------------------------------------- | ------------- | ------------------------------------------------ |
| Desligar vídeo após (AC/DC)                                       | 0             | Nunca — requer `/attributes + /setacvalueindex`. |
| Suspensão seletiva de USB                                         | 0             | Desativada — mantém dispositivos ativos.         |
| Core Parking (núcleos mínimos ativos)                             | 100           | Garante todos os núcleos ativos.                 |
| Boost Mode / Energy Preference / WakeTimers / JS Timer / AwayMode | 100/100/Ativo | Ajustado conforme o script principal.            |

> ⚠️ *Nota:* Alguns ajustes podem ser ignorados por restrições de privilégios administrativos, builds *Insider* ou interferência da *Game Bar*.

---

## 🧩 **Observações Técnicas Importantes**

* O parâmetro `VisualFXSetting = 2` é ignorado nas builds 24H2/25H2 — utilize **3** para o modo *Custom*.
* A build **25H2** introduziu o **Energy Efficiency Scheduler**, ativo apenas nos planos **Alto Desempenho** ou **Ultimate Performance**.
* Scripts atualizados utilizam `/attributes` e correções de validação de parâmetros `max` para consistência.

---

# 🔒 **Privacidade e Telemetria — Revisão 25H2**

### ✅ 1. **Coleta de Dados e Personalização**

Desativa chaves como `AllowTelemetry`, `AllowInputPersonalization` e `TailoredExperiences`, reduzindo a coleta de dados e personalizações em nuvem.
📚 *Fonte:* [Microsoft Learn](https://learn.microsoft.com)

---

### ✅ 2. **Publicidade e Aplicativos em Segundo Plano**

Bloqueia `AdvertisingInfo`, `EnableWebContentEvaluation`, `DisableSearchBoxSuggestions` e restringe `BackgroundAccessApplications`, reduzindo rastreamento e anúncios direcionados.
📚 *Fonte:* [The Register](https://www.theregister.com)

---

### ✅ 3. **Funcionalidades do Navegador (Edge)**

Desativa `DoNotTrack`, `ShowSearchSuggestionsGlobal`, `FPEnabled` e `EnabledV9` — eliminando rastreamento e sugestões baseadas em histórico.
📚 *Fonte:* [The Register](https://www.theregister.com)

---

## 🌐 **Privacidade em Navegadores Populares**

### 🔒 Mozilla Firefox

```ini
toolkit.telemetry.enabled = false
toolkit.telemetry.unified = false
toolkit.telemetry.server = 0.0.0.0
```

Desative *Sync* e *Autofill* em `about:preferences`.
📚 *Fonte:* Mozilla Support / SuperUser

---

### 🧭 Opera

* Desative *Autofill* em `opera://settings/addresses`
* Desative *Sync* em `opera://settings/syncSetup`
* Ative “Bloquear rastreadores” em `opera://settings/privacy`
  📚 *Fonte:* Reddit / Fingerprint.com

---

### 🍎 Safari (macOS)

* Desative *Preenchimento Automático* e *Relatório de Privacidade* em **Preferências > Privacidade**
* Desative “Medição de Anúncios Preservando a Privacidade”
  📚 *Fonte:* Apple / BrowserHow

---

### 🦁 Brave

* Desative telemetria em `brave://settings/privacy`
* Desative *WebRTC* via `brave://flags/#disable-webrtc`
  📚 *Fonte:* Brave Support / Foliovision

---

## 🧠 **Recall — Métodos para Desativar**

### 🔧 Método 1 — Configurações do Windows

`Configurações > Privacidade e segurança > Recall & instantâneos` → desative **Salvar instantâneos**.
📚 *Fonte:* Microsoft Support

---

### 🛠️ Método 2 — Recursos do Windows

1. Acesse *Ativar ou desativar recursos do Windows*
2. Desmarque **Recall**
3. Clique em **OK** e reinicie o sistema
   📚 *Fonte:* Tuta.io

---

### ⚙️ Método 3 — Política de Grupo (Pro / Enterprise)

`gpedit.msc` →
`Configuração do Computador > Modelos Administrativos > Componentes do Windows > Windows AI`
Defina **Permitir Recall** como **Desativado**.

---

### 🧩 Método 4 — Editor de Registro

```reg
[HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Windows\WindowsAI]
"AllowRecallEnablement"=dword:00000000
```

> 🔁 Reinicie o sistema para aplicar as alterações.

---

# 🎮 **Otimizações NVIDIA — Windows 11 (25H2)**

| Categoria                 | Valor / Ajuste                   | Objetivo                           |
| ------------------------- | -------------------------------- | ---------------------------------- |
| `TDR`                     | `0`                              | Evita reset da GPU                 |
| `HwSchedMode`             | `2`                              | Usa o agendador de hardware da GPU |
| `Low Latency`             | `1`                              | Reduz input lag                    |
| `FlipNoVsync`             | `1`                              | Menor latência com VRR ativo       |
| `PowerSavingTweaks`       | `0`                              | Desativa economia de energia       |
| `DisableWriteCombining`   | `1`                              | Evita overhead de memória de vídeo |
| `EnablePerformanceMode`   | `1`                              | Prioriza desempenho máximo         |
| `EnableVrrFrameSmoothing` | `1`                              | Suaviza FPS variável               |
| Registry loops            | Consolidar HKCU/HKLM/HKU\DEFAULT | Simplifica manutenção              |

---

## 🧱 **Estrutura Recomendada de Script (PowerShell)**

### Modularização

* `Core NVIDIA (nvlddmkm)`
* `GraphicsDrivers (TdrLevel, HwSchedMode)`
* `Direct3D / DirectDraw`
* `PCI / PowerSaving`

### Checagem Condicional

```powershell
if (-not (Test-Path "HKLM:\SYSTEM\CurrentControlSet\Services\nvlddmkm")) {
    New-Item "HKLM:\SYSTEM\CurrentControlSet\Services\nvlddmkm"
}
```

Evite duplicações — centralize chaves de energia e raiz em loops controlados.

---

# 🌐 **Otimização da Pilha TCP/IP (PowerShell)**

### 1️⃣ Executar como Administrador

Abra o **PowerShell (Admin)** pelo menu Iniciar.

---

### 2️⃣ Verificar o Provedor Atual

```powershell
Get-NetTCPSetting | Select SettingName, CongestionProvider
```

Por padrão, o Windows usa **CUBIC**. Recomenda-se **BBR2** para redes modernas.

---

### 3️⃣ Ativar o Provedor BBR2

```cmd
netsh int tcp set supplemental Template=Internet CongestionProvider=bbr2
netsh int tcp set supplemental Template=Datacenter CongestionProvider=bbr2
```

---

### 4️⃣ Habilitar Autotuning da Janela de Recepção

```powershell
Set-NetTCPSetting -AutoTuningLevelLocal Normal
```

Verifique:

```powershell
Get-NetTCPSetting | Select SettingName, AutoTuningLevelLocal
```

---

### 5️⃣ Ajustar a Janela de Congestionamento Inicial

```powershell
Set-NetTCPSetting -SettingName "Custom" -InitialCongestionWindowMss 64
```

Melhora conexões de alta largura de banda.

---

### 🔧 Outros Comandos Úteis

| Função                              | Comando                                                                          | Fonte              |
| ----------------------------------- | -------------------------------------------------------------------------------- | ------------------ |
| **Reset de Rede**                   | `netsh int ip reset`                                                             | Reddit             |
| **Estatísticas do Adaptador**       | `Get-NetAdapterStatistics -Name "Ethernet"`                                      | Medium             |
| **Conexões TCP Ativas**             | `Get-NetTCPConnection`                                                           | Boson Treinamentos |
| **Teste de Conectividade Avançado** | `Test-NetConnection www.exemplo.com -InformationLevel Detailed`                  | Boson Treinamentos |
| **Registrar DNS Dinâmico (DDNS)**   | `Set-DnsClient -InterfaceAlias "Ethernet" -RegisterThisConnectionsAddress $true` | Microsoft Learn    |
| **Gerenciar Firewall**              | `Set-NetFirewallProfile -Profile Domain,Public,Private -Enabled True`            | Microsoft Learn    |

---

**📅 Última atualização:** 12/10/2025
**👤 Autor:** Bernardo *(B7)*
**🔗 Projeto:** [B7 Cyber Boost](https://github.com/B7-Bernardo/B7-Cyber-Boost)

---

