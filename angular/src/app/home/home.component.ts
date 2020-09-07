import { AuthService } from '@abp/ng.core';
import { Component } from '@angular/core';
import { OAuthService } from 'angular-oauth2-oidc';
import { environment } from '../../environments/environment';
import * as signalR from "@aspnet/signalr";


@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
})
export class HomeComponent {
  get hasLoggedIn(): boolean {
    return this.oAuthService.hasValidAccessToken();
  }

  private hubConnection: signalR.HubConnection

  constructor(private oAuthService: OAuthService, private authService: AuthService) {
    if(this.hasLoggedIn){
        this.hubConnection = new signalR.HubConnectionBuilder()
      .withUrl(`${environment.apis.default.url}/signalr-hubs/chatting`,
          { accessTokenFactory: () => this.oAuthService.getAccessToken() })
      .build();

      this.hubConnection.start();
    }
  }

  login() {
    this.authService.initLogin();
  }
}
