import { HttpClient } from "@angular/common/http";
import { Component, Inject } from "@angular/core";
@Component({
    selector: 'app-payment-component',
    templateUrl: './ticket.payment.component.html'
})
export class TicketPaymentComponent {
  
    public isPaymentCompelete : boolean;
    public cost : number;
    public url: string;

    constructor(public http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
        this.url = baseUrl;
    }
    public makePayment() {
        //this.http.post(this.url + 'Ticket').subscribe(result => {
       
        //}, error => console.error(error));
    }
}