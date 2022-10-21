using System.Diagnostics;

//Per svolgere questo test tecnico avrete a disposizione oggi e domani. Questo test tecnico vi permetterà di cimentarvi nello sviluppo di una webapp “completa” così come potrebbe capitarvi nella vostra futura carriera lavorativa.
//Riprendiamo un bel esercizietto fatto qualche tempo fa: bootstrap - travel - agency, questa volta però potrete sbizzarrirvi come volete con la grafica a partire anche da quanto avevate già fatto in precedenza.
//L’obiettivo sarà dunque quello di creare una webapp per un’agenzia di viaggi utilizzando l’approccio MVC / WebApi ed Entity Framework. L’agenzia vi commissiona questo progetto che prevede una parte di visualizzazione pacchetti viaggio offerti ai clienti e un’area di amministrazione per gestire i pacchetti proposti.
//Il progetto sarà suddiviso in MILESTONE.
//Per adesso vi fornisco la prima milestone, successivamente riceverete le altre.


//MILESTONE 1:

//In questa milestone andremo ad implementare l’area di amministrazione con tutte le funzionalità CRUD dei nostri pacchetti viaggio. Avremo quindi una pagina Index che mostrerà l’elenco in forma tabellare dei pacchetti che offriamo.
//Da questa pagina potremo:
//    Visualizzare nel dettaglio un pacchetto
//    Aggiungere un nuovo pacchetto
//    Modificare un pacchetto esistente
//    Eliminare un pacchetto esistente
//Pertanto ricordatevi di creare il vostro modello PacchettoViaggio.cs e di configurare il vostro Entity Framework per poter salvare e gestire tutti i vostri pacchetti anche lato Database. Queste pagine dovranno essere realizzate utilizzando l’approccio MVC + Razor + Entity Framework. Non dimenticate di usare e configurare il Layout del sito.


//MILESTONE 2: 

//Ora che il programma dovrebbe aver preso una prima forma, eccovi le indicazioni della seconda milestone. Ragioniamo se ci siano o meno impatti su quello che stiamo già realizzando (layout, controller, entità, relazioni) e in base alla complessità dell’impatto valutiamo se dobbiamo già ristrutturare un pò il codice oppure se va bene così. Non abbiate fretta di partire con la seconda milestone in caso la prima non sia ancora consolidata.

//Implementare l’Homepage dell’agenzia di viaggio che mostra l’elenco dei pacchetti offerti. L’utente potrà quindi visualizzare in pacchetti in maniera chiara e “user-friendly”.
//In questo caso vi si chiede di implementare l’Homepage sfruttando le Web API, di conseguenza dovrete restituire una View con del codice Javascript per visualizzare la vostra lista di pacchetti che vi verranno forniti come oggetto JSON alla chiamata tramite AXIOS verso la vostra web API che creerete.


//MILESTONE 3:

//Attenzione è in arrivo una nuova richiesta!
//Anche in questo caso valutiamo gli impatti e predisponiamo le attività; in coda, se stiamo terminando una delle precedenti richieste, oppure iniziamo a  progettarla e svilupparla se stiamo facendo attività di miglioramento, che proseguiranno poi successivamente alla chiusura di questa terza milestone.

//In questa milestone l’agenzia vi chiede inoltre anche la possibilità di ricercare un pacchetto nella sua Homepage, in modo che un utente inserendo una stringa di ricerca in un’apposita area di testo, questa venga inviata tramite AXIOS alla vostra web API. La web API dovrà occuparsi di restituire i pacchetti che hanno la stringa di ricerca presente o nel titolo del pacchetto o nella descrizione e la pagina una volta ricevute le informazioni, si dovrà occupare di aggiornare la pagina con i pacchetti ricercati.


//MILESTONE 4: 

//Sempre nella Homepage, prevedere un bottone (oppure ancora meglio un evento click sull’intera card) per andare nei dettagli del pacchetto di cui l’utente vuole avere maggiori informazioni e visualizzare singolarmente. Anche questa pagina di dettaglio pacchetto dovrà essere popolata con i dati provenienti da una chiamata AXIOS alla web API che fornisce l’oggetto JSON del pacchetto selezionato.


//MILESTONE 5: 
    
//Prevedere una Web API con cui sia possibile inviare un messaggio da parte del cliente all’agenzia per richiedere ulteriori informazioni in merito al pacchetto visualizzato nella pagina dettaglio pacchetto. Questa API potrà essere richiamata tramite AXIOS, a partire dalla pagina di visualizzazione dettagliata di un singolo pacchetto, una volta che avrà compilato un apposito form presente nella pagina. L’API dovrà occuparsi di salvare tale messaggio nel database che verrà associato al pacchetto dove è stata richiesta l’informazione
//Se la richiesta è chiara procedete concordemente alle attività che avete in coda,
//altrimenti ricordatevi sempre di chiedere chiarimenti.
