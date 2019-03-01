import { Routes } from '@angular/router'
import { HomeComponent } from './home/home.component';
import { MemberListComponent } from './memberList/memberList.component';
import { ListsComponent } from './lists/lists.component';
import { MessagesComponent } from './messages/messages.component';

export const appRoutes: Routes = [
    {path: 'home', component: HomeComponent},
    {path: 'members', component: MemberListComponent},
    {path: 'lists', component: ListsComponent},
    {path: 'messages', component: MessagesComponent},
    {path: '**', redirectTo: 'home', pathMatch: 'full'}
];
