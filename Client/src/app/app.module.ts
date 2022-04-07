import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { BrowserAnimationsModule } from "@angular/platform-browser/animations"
import { ToastrModule } from 'ngx-toastr';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { DatePipe } from '@angular/common';
import { NgxEditorModule } from 'ngx-editor';
import { CommonModule } from "@angular/common";
import {ngfModule} from "angular-file";

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { SideBarComponent } from './home/side-bar/side-bar.component';
import { HeaderBarComponent } from './home/header-bar/header-bar.component';
import { ListCandidatsComponent } from './candidats/list-candidats/list-candidats.component';
import { ListCollaborateursComponent } from './collaborateurs/list-collaborateurs/list-collaborateurs.component';
import { HomeComponent } from './home/home.component';
import { SigninComponent } from './auth/signin/signin.component';
import { SignupComponent } from './auth/signup/signup.component';
import { ToDoComponent } from './to-do/list-todo/to-do.component';
import { MemoComponent } from './memos/memo/memo.component';
import { AboutComponent } from './about/about.component';
import { DashboardComponent } from './dashboard/dashboard.component';
import { NotFoundComponent } from './errors/not-found/not-found.component';
import { ServerErrorComponent } from './errors/server-error/server-error.component';
import { TestErrorsComponent } from './errors/test-errors/test-errors.component';
import { FormationsComponent } from './formations/formations.component';
import { IntegrationsComponent } from './integrations/integrations.component';
import { ReportsComponent } from './reports/reports.component';
import { DemissionsComponent } from './demissions/demissions.component';
import { AddEditTodoComponent } from './to-do/add-edit-todo/addEditTodo.component';
import { ListFreelancesComponent } from './freelances/list-freelances/list-freelances.component';
import { AddEditFreelancesComponent } from './freelances/add-edit-freelances/add-edit-freelances.component';
import { AddEditMemosComponent } from './memos/add-edit-memos/add-edit-memos.component';
import { AddEditCandidatComponent } from './candidats/add-edit-candidat/add-edit-candidat.component';
import { AddEditCollaborateurComponent } from './collaborateurs/add-edit-collaborateur/add-edit-collaborateur.component';
import { LayoutComponent } from './layout/layout.component';
import { ModalComponent } from './shared/modal/modal.component';
import { ToastComponent } from './shared/toast/toast.component';
import { SpinnerComponent } from './shared/spinner/spinner.component';
import { ImportCollabsComponent } from './collaborateurs/import-collabs/import-collabs.component';

@NgModule({
  declarations: [
    AppComponent,
    SideBarComponent,
    HeaderBarComponent,
    ListCandidatsComponent,
    ListCollaborateursComponent,
    HomeComponent,
    SigninComponent,
    SignupComponent,
    ToDoComponent,
    MemoComponent,
    AboutComponent,
    DashboardComponent,
    NotFoundComponent,
    ServerErrorComponent,
    TestErrorsComponent,
    FormationsComponent,
    IntegrationsComponent,
    ReportsComponent,
    DemissionsComponent,
    AddEditTodoComponent,
    ListFreelancesComponent,
    AddEditFreelancesComponent,
    AddEditMemosComponent,
    AddEditCandidatComponent,
    AddEditCollaborateurComponent,
    LayoutComponent,
    ModalComponent,
    ToastComponent,
    SpinnerComponent,
    ImportCollabsComponent
  ],
  imports: [
    CommonModule,
    BrowserModule,
    AppRoutingModule,
    FormsModule,
    ReactiveFormsModule,
    HttpClientModule,
    NgxEditorModule,
    ToastrModule.forRoot({
      positionClass: 'toast-top-right',
      timeOut: 2000,
      closeButton: true
    }),
    BrowserAnimationsModule,
    ngfModule
  ],
  providers: [DatePipe],
  bootstrap: [AppComponent]
})
export class AppModule { }
