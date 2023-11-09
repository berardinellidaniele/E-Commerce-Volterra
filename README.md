# E-Clothes
Un progetto per gestire un e-commerce in Windows Forms C#

![E-Clothes Home](https://github.com/0xBerard/E-Commerce-Volterra/blob/main/principale.jpg)

## Da fare
- [ ] Commentare il codice
- [ ] Creare gli schemi UML

## In corso
- [ ] Presentazione PowerPoint

## Fatto ✓
- [x] Crare l'interfaccia di register e login
- [x] Creare l'interfaccia principale


## Framework Utilizzati

![Bunifu Framework](https://github.com/0xBerard/E-Commerce-Volterra/blob/main/bunifu.png)

**Bunifu** è un framework per migliorare l'interfaccia grafica. Esso include degli elementi grafici non disponibili in WinForms.


## Diagrammi UML

### Diagramma della classe User
```mermaid
classDiagram
    class User {
      -string Username
      -string Password
      +User(string, string)
      +bool CheckPassword(string)
    }
```
### Diagramma della classe C_Prodotto
```mermaid
classDiagram
    class C_Prodotto {
      -image Immagine
      -string Nome
      -double Prezzo
      -int Quantità
      +C_Prodotto(image, string, double, int)
    }
```
