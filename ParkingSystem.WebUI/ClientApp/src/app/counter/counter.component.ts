import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-counter-component',
  templateUrl: './counter.component.html'
})
export class CounterComponent {
    public currentCount = 0;

    public url: string;

    constructor(public http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
        this.url = baseUrl;
    }
    public generateTicket() {
        this.http.get<number>(this.url + 'Ticket').subscribe(result => {
            this.currentCount = result;
      }, error => console.error(error));
  }
}

    