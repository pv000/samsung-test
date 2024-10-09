import { Component, ElementRef, inject, OnInit, ViewChild } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { UsersService } from './services/users.service';
import { User } from './models/user.model';
import { AddressService } from './services/address.service';
import { ClickOutsideDirective } from './directives/click-outside.directive';

@Component({
    selector: 'app-root',
    standalone: true,
    imports: [RouterOutlet, ClickOutsideDirective],
    templateUrl: './app.component.html',
    styleUrl: './app.component.scss'
})
export class AppComponent implements OnInit {
    @ViewChild('dialog') dialog: ElementRef<HTMLDialogElement> | undefined;

    public users: User[] = [];
    public selectedUser: User | undefined;

    private usersService = inject(UsersService);
    private addressService = inject(AddressService);

    ngOnInit(): void {
        this.usersService.getUsers().subscribe({
            next: users => {
                this.users = users;
            },
            error: () => console.log('Failed to fetch users')
        });
    }

    selectUser(user: User): void {
        this.selectedUser = user;
        if (this.selectedUser.address) {
            this.openDialog();
            return;
        }

        this.addressService.getAddressByUserId(this.selectedUser.id).subscribe({
            next: address => {
                this.selectedUser!.address = address
                this.openDialog();
            },
            error: () => console.log(`Failed to fetch user ${this.selectedUser!.id} address.`)
        })

    }

    openDialog(): void {
        if (this.dialog) {
            this.dialog.nativeElement.showModal();
        }
    }

    closeDialog(): void {
        if (this.dialog) {
            this.dialog.nativeElement.close();
        }
    }
}
