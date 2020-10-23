import { AccountService } from './account/account.service';
import { Component, OnInit } from '@angular/core';
import { BasketService } from './basket/basket.service';
import { error } from 'protractor';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss'],
})
export class AppComponent implements OnInit {
  title = 'Skinet';

  constructor(private basketService: BasketService, private accountService: AccountService) {}

  ngOnInit(): void {
    this.loadBasket();
    this.loadCurrentUser();
  }

  loadCurrentUser(){
    const token = localStorage.getItem('token');
    this.accountService.loadCurrntUser(token).subscribe(() => {
      console.log('Loaded user');
      // tslint:disable-next-line: no-shadowed-variable
      }, error => {
      console.log(error);
      });
  }

  loadBasket(){
    const basketId = localStorage.getItem('basket_id');
    if (basketId) {
      this.basketService.getBasket(basketId).subscribe(() => {
        console.log('initialized basket');
      // tslint:disable-next-line: no-shadowed-variable
      }, error => {
        console.log(error);
      });
    }
  }
}
