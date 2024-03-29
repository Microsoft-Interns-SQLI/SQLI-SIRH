import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { SigninComponent } from './auth/signin/signin.component';
import { AddEditCandidatComponent } from './candidats/add-edit-candidat/add-edit-candidat.component';
import { ListCandidatsComponent } from './candidats/list-candidats/list-candidats.component';
import { AddEditCollaborateurComponent } from './collaborateurs/add-edit-collaborateur/add-edit-collaborateur.component';
import { ListCollaborateursComponent } from './collaborateurs/list-collaborateurs/list-collaborateurs.component';
import { DashboardComponent } from './dashboard/dashboard.component';
import { DemissionsComponent } from './demissions/demissions.component';
import { NotFoundComponent } from './errors/not-found/not-found.component';
import { ServerErrorComponent } from './errors/server-error/server-error.component';
import { TestErrorsComponent } from './errors/test-errors/test-errors.component';
import { FormationsComponent } from './formations-certifications/formations.component';
import { ListFreelancesComponent } from './freelances/list-freelances/list-freelances.component';
import { AuthentificationGuardService } from './guards/authentification.guard.service';
import { HomeComponent } from './home/home.component';
import { IntegrationsComponent } from './integrations/integrations.component';
import { AuthentificationInterceptor } from './interceptors/authentification.interceptor';
import { JobsPanelComponent } from './jobs-panel/jobs-panel.component';
import { LayoutComponent } from './layout/layout.component';
import { MdmPanelComponent } from './mdm-panel/mdm-panel.component';
import { AddEditMemosComponent } from './memos/add-edit-memos/add-edit-memos.component';
import { MemoComponent } from './memos/memo/memo.component';
import { ReportsComponent } from './reports/reports.component';
import { ToDoComponent } from './to-do/list-todo/to-do.component';
import { UploadComponent } from './upload/upload.component';

export const routes: Routes = [
  { path: 'login', component: SigninComponent },
  {
    path: '',
    component: LayoutComponent,
    canActivateChild: [AuthentificationGuardService],
    children: [
      { path: '', redirectTo: 'home', pathMatch: 'full' },
      { path: 'home', component: HomeComponent },
      { path: 'dashboard', component: DashboardComponent },
      { path: 'candidats', component: ListCandidatsComponent },
      { path: 'addEditcandidats', component: AddEditCandidatComponent },
      {
        path: 'collaborateurs',
        component: ListCollaborateursComponent,
        data: {
          saveComponent: true,
        },
      },
      {
        path: 'addEditcollaborateur',
        component: AddEditCollaborateurComponent,
      },
      {
        path: 'addEditcollaborateur/:id',
        component: AddEditCollaborateurComponent,
      },
      { path: 'todo', component: ToDoComponent },
      { path: 'memo', component: MemoComponent },
      { path: 'addEdiMemos', component: AddEditMemosComponent },
      { path: 'reports', component: ReportsComponent },
      { path: 'formations', component: FormationsComponent },
      { path: 'integrations', component: IntegrationsComponent },
      { path: 'demissions', component: DemissionsComponent },
      { path: 'freelances', component: ListFreelancesComponent },
      { path: 'errors', component: TestErrorsComponent },
      { path: 'not-found', component: NotFoundComponent },
      { path: 'server-error', component: ServerErrorComponent },
      { path: 'upload', component: UploadComponent },
      { path: 'mdm', component: MdmPanelComponent },
      { path: 'jobs', component: JobsPanelComponent },
    ],
  },

  // {
  //   path: '',
  //   runGuardsAndResolvers: 'always',
  //   canActivate: [AuthGuard],
  //   children: [
  //     { path: 'members', component: MemberListComponent },
  //     { path: 'members/:username', component: MemberDetailComponent, resolve: {member: MemberDetailedResolver} },
  //     { path: 'member/edit', component: MemberEditComponent, canDeactivate: [PreventUnsavedChangesGuard] },
  //     { path: 'lists', component: ListsComponent },
  //     { path: 'messages', component: MessagesComponent },
  //     { path: 'admin', component: AdminPanelComponent, canActivate: [AdminGuard] },
  //   ],
  // },
];

@NgModule({
  imports: [RouterModule.forRoot(routes, { onSameUrlNavigation: 'reload' })],
  exports: [RouterModule],
})
export class AppRoutingModule {}
