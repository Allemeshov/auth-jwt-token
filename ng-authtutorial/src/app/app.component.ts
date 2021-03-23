import { Component } from '@angular/core';
import { AuthService } from './services/auth.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss'],
})
export class AppComponent {
  public get isLoggedIn(): boolean {
    // alert(this.as.isAuthenticated());
    return this.as.isAuthenticated();
  }

  constructor(private as: AuthService) {}

  login(email: string, password: string) {
    this.as.login(email, password).subscribe(
      (res) => {},
      (error) => {
        alert(`Wrong login and password.`);
        console.log(error);
      }
    );
  }

  logout() {
    this.as.logout();
  }
}
