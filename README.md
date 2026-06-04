# Getränkeautomat - Grafische Automatoberfläche

Ein Windows-Anwendung in C# (.NET Framework 4.7.2), die einen Getränkeautomaten mit grafischer Benutzeroberfläche simuliert.

## 📋 Übersicht

Diese Anwendung bietet eine vollständige Simulation eines Getränkeautomaten mit:
- Verschiedenen Getränkeoptionen (Cola, Fanta, Cola Zero, Red Bull, Wasser, Eistee)
- Münz- und Scheinakzeptor
- Automatische Rückgeldberechnung und -ausgabe
- Echtzeit-Status-Anzeige
- Verwaltung von Bestandsmengen und Finanzinformationen

## 🚀 Features

### Getränkeauswahl
- **Cola**: 2,50 €
- **Fanta**: 2,00 €
- **Cola Zero**: 2,00 €
- **Red Bull**: 3,00 €
- **Wasser**: 1,00 €
- **Eistee**: 1,50 €

### Zahlungssystem
- Akzeptiert Münzen und Scheine (5 €, 10 €, 2 €, 1 €, 50¢, 20¢, 10¢, 5¢)
- Automatische Guthaben-Verwaltung
- Intelligente Rückgeldberechnung und Auszahlung
- Maximale Einwurfgrenze: 20 €

### Verwaltung
- Bestandsverwaltung für jedes Getränk
- Münzlagerbestand-Tracking
- Umsatzberechnung
- Ausgabestatus mit Fehlermeldungen

## 🛠️ Technologie

- **Sprache**: C#
- **.NET Framework**: 4.7.2
- **UI**: Windows Forms
- **Output-Typ**: Windows-Anwendung (WinExe)

## 💻 Anforderungen

- Windows 7 oder höher
- .NET Framework 4.7.2

## 📁 Projektstruktur

```
Getraenkeautomat/
├── Grafische Automatoberflaeche/
│   ├── Form1.cs          # Hauptformular mit Logik
│   ├── Program.cs        # Einstiegspunkt
│   └── *.csproj          # Projektdatei
└── README.md             # Diese Datei
```

## 🎯 Verwendung

1. Öffnen Sie das Projekt in Visual Studio 2022+
2. Bauen Sie die Lösung (Strg + Shift + B)
3. Starten Sie die Anwendung (F5)
4. Werfen Sie Münzen/Scheine ein
5. Wählen Sie ein Getränk
6. Erhalten Sie automatisch Rückgeld (falls notwendig)

## ⚙️ Hauptfunktionen der Anwendung

### Geldverwaltung
- `GeldReicht()`: Überprüft, ob ausreichend Rückgeld vorhanden ist
- `Geldrueckgabe()`: Verarbeitet die Rückgeldauszahlung

### Getränkekauf
- Verfügbarkeitsprüfung
- Preisvalidierung
- Bestandsverwaltung nach Verkauf
- Statusmeldungen für Benutzer

## 📝 Lizenz

Dieses Projekt wurde zu Lernzwecken erstellt.

## 📧 Support

Bei Fragen oder Problemen konsultieren Sie den Quellcode oder öffnen Sie die Anwendung in Visual Studio.

---

**Hinweis**: Dies ist eine Simulationsanwendung für Lernzwecke und hat keine echten Auswirkungen auf reale Getränkeautomaten.
