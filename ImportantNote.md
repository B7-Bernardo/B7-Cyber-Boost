

---

# ⚙️ B7 Cyber Boost — Nota Importante

### 📘 Compatibilidade Confirmada

**Windows 10 e 11 — Builds 24H2 / 25H2**

> Atualização sobre comandos `bcdedit` e ajustes de energia para garantir **execução limpa**, **sem erros de log**, e **máxima eficiência de desempenho**.

---

## 🧠 Comandos `bcdedit` Removidos ou Obsoletos

| Comando                                       | Status         | Observação Técnica                                                   |
| --------------------------------------------- | -------------- | -------------------------------------------------------------------- |
| `bcdedit /set vm Yes`                         | ❌ Removido     | Virtualização agora é gerenciada automaticamente.                    |
| `bcdedit /set vsmlaunchtype Auto`             | ❌ Removido     | O VSM é iniciado de forma automática; comando ignorado.              |
| `bcdedit /deletevalue isolatedcontext`        | ❌ Removido     | Substituído por mecanismos de segurança baseados em VBS.             |
| `bcdedit /deletevalue MSI`                    | ❌ Removido     | Sem efeito em builds modernas.                                       |
| `bcdedit /deletevalue usefirmwarepcisettings` | ❌ Removido     | Obsoleto em sistemas UEFI; controle é feito pelo Windows.            |
| `bcdedit /deletevalue x2apicpolicy`           | ❌ Removido     | Ignorado em CPUs atuais.                                             |
| `bcdedit /set linearaddress57 OptOut`         | ❌ Removido     | Não suportado.                                                       |
| `bcdedit /set allowedinmemorysettings 0x0`    | ❌ Removido     | Sem efeito prático.                                                  |
| `bcdedit /set usephysicaldestination No`      | ❌ Removido     | Ignorado.                                                            |
| `bcdedit /set tscsyncpolicy Legacy input`     | ⚙️ Substituído | Use `tscsyncpolicy Enhanced` para sincronização de TSC mais precisa. |

> ✅ **Resultado:** Scripts otimizados e compatíveis com builds modernas; execução estável e sem resíduos de comandos depreciados.

---

## ⚡ Ajustes de Energia — Recomendados (Windows 11 25H2)

### 1️⃣ Ativar o Plano **Desempenho Máximo (Ultimate Performance)**

```cmd
powercfg -duplicatescheme e9a42b02-d5df-448d-aa00-03f14749eb61
powercfg -setactive e9a42b02-d5df-448d-aa00-03f14749eb61
```

### 2️⃣ Desativar Recursos de IA (Copilot / Recall)

```cmd
reg add "HKLM\SOFTWARE\Microsoft\PolicyManager\current\device\Experience" /v AllowCopilot /t REG_DWORD /d 0 /f
reg add "HKLM\SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\Advanced" /v ShowCopilotButton /t REG_DWORD /d 0 /f
```

### 3️⃣ Configurações de Energia Avançadas

| Configuração                                                          | Valor         | Observação Técnica                               |
| --------------------------------------------------------------------- | ------------- | ------------------------------------------------ |
| **Desligar vídeo após (AC/DC)**                                       | 0             | Nunca — requer `/attributes + /setacvalueindex`. |
| **Suspensão seletiva de USB**                                         | 0             | Desabilitada — mantém dispositivos ativos.       |
| **Core Parking (mínimo de núcleos ativos)**                           | 100           | Ignorado se `max = 0`.                           |
| **Boost Mode / Energy Preference / WakeTimers / JS Timer / AwayMode** | 100/100/Ativo | Ajustado conforme script principal.              |

> ⚠️ **Atenção:** alguns ajustes podem ser ignorados por falta de permissão administrativa, bugs em builds *Insider* ou limitações da *Game Bar*.

---

## 🧩 Observações Técnicas Importantes

* O parâmetro `VisualFXSetting = 2` é ignorado nas builds 24H2/25H2 — use **3** para o modo “Custom”.
* A build **25H2** introduziu o **Energy Efficiency Scheduler**, ativo apenas com os planos **Alto Desempenho** ou **Ultimate Performance**.
* Scripts foram atualizados para usar `/attributes` e corrigir validações de `max` em parâmetros discretos.

---

# 🔒 Privacidade do Usuário — Revisão 25H2

### ✅ 1. Coleta de Dados e Personalização

Desativa chaves como `AllowTelemetry`, `AllowInputPersonalization` e `TailoredExperiences`, reduzindo a coleta de dados diagnósticos e personalizações em nuvem.
📚 *Fonte:* Microsoft Learn

---

### ✅ 2. Publicidade e Aplicativos em Segundo Plano

Bloqueia recursos como `AdvertisingInfo`, `EnableWebContentEvaluation`, `DisableSearchBoxSuggestions` e restrições para `BackgroundAccessApplications`, reduzindo rastreamento e anúncios direcionados.
📚 *Fonte:* theregister.com

---

### ✅ 3. Funcionalidades do Navegador (Edge)

Modifica chaves como `DoNotTrack`, `ShowSearchSuggestionsGlobal`, `FPEnabled` e `EnabledV9`, desativando rastreamento e sugestões baseadas em histórico.
📚 *Fonte:* theregister.com

---

## 🌐 Privacidade em Navegadores Populares

### 🔒 **Mozilla Firefox**

* `toolkit.telemetry.enabled` → `false`
* `toolkit.telemetry.unified` → `false`
* `toolkit.telemetry.server` → `0.0.0.0`
* Desative *Sync* e *Preenchimento Automático* em `about:preferences`.

📚 *Fonte:* SuperUser / Mozilla Support

---

### 🧭 **Opera**

* Desative *Autofill* em `opera://settings/addresses`.
* Desative *Sync* em `opera://settings/syncSetup`.
* Ative “Bloquear rastreadores” em `opera://settings/privacy`.

📚 *Fonte:* Reddit / Fingerprint.com

---

### 🍎 **Safari (macOS)**

* Desative *Preenchimento Automático* e *Relatório de Privacidade* em **Preferências > Privacidade**.
* Desative “Medição de Anúncios Preservando a Privacidade”.

📚 *Fonte:* Apple / BrowserHow

---

### 🦁 **Brave**

* Desative telemetria em `brave://settings/privacy`.
* Desative *Autofill em navegação privada*.
* Desative *WebRTC* em `brave://flags/#disable-webrtc`.

📚 *Fonte:* support.brave.app / Foliovision

---

## 🧠 Recall — Métodos para Desativar

### 🔧 Método 1 — Via Configurações do Windows

**Caminho:** `Configurações > Privacidade e segurança > Recall & instantâneos`
Desative **Salvar instantâneos**.
📚 *Fonte:* Microsoft Support

---

### 🛠️ Método 2 — Remover Recall (via Recursos do Windows)

1. Abra *Ativar ou desativar recursos do Windows*.
2. Desmarque **Recall**.
3. Clique em **OK** e reinicie o sistema.
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

**📅 Última atualização:** 10/10/2025
**👤 Autor:** Bernardo *(B7)*
**🔗 Projeto:** [B7 Cyber Boost](https://github.com/B7-Bernardo/B7-Cyber-Boost)

---

