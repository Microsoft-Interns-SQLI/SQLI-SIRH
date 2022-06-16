import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { ToastrModule } from 'ngx-toastr';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { HttpClientModule, HTTP_INTERCEPTORS } from '@angular/common/http';
import { DatePipe } from '@angular/common';
import { NgxEditorModule } from 'ngx-editor';
import { CommonModule } from '@angular/common';
import { PaginationModule } from 'ngx-bootstrap/pagination';
import { ngfModule } from 'angular-file';

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
import { FormationsComponent } from './formations-certifications/formations.component';
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
import { UploadComponent } from './upload/upload.component';
import { ImportCollabsComponent } from './collaborateurs/import-collabs/import-collabs.component';
import { DownloadComponent } from './download/download.component';
import { AddEditSummaryCardComponent } from './collaborateurs/add-edit-collaborateur/add-edit-summary-card/add-edit-summary-card.component';
import { AddEditFormTableComponent } from './collaborateurs/add-edit-collaborateur/add-edit-form-table/add-edit-form-table.component';
import { NgxSpinnerModule } from 'ngx-spinner';
import { LoadingInterceptor } from './interceptors/loading.interceptor';
import { TextInputComponent } from './collaborateurs/add-edit-collaborateur/add-edit-form-table/_form_inputs/text-input/text-input.component';
import { TextareaInputComponent } from './collaborateurs/add-edit-collaborateur/add-edit-form-table/_form_inputs/textarea-input/textarea-input.component';
import { SelectInputComponent } from './collaborateurs/add-edit-collaborateur/add-edit-form-table/_form_inputs/select-input/select-input.component';
import { HeaderComponent } from './collaborateurs/header/header.component';
import { FooterComponent } from './collaborateurs/footer/footer.component';
import { TableComponent } from './formations-certifications/table/table.component';
import { DisplayItemDirective } from './formations-certifications/table/display-item.directive';
import { HandleStatusDisplayPipe } from './formations-certifications/table/handle-status-display.pipe';
import { PopupComponent } from './formations-certifications/popup/popup.component';
import { MdmPanelComponent } from './mdm-panel/mdm-panel.component';
import { HeaderFormationCertificationComponent } from './formations-certifications/header-formation-certification/header-formation-certification.component';
import { NgSelectModule } from '@ng-select/ng-select';
import { DemissionTabComponent } from './collaborateurs/add-edit-collaborateur/add-edit-form-table/_demission_tab/demission-tab/demission-tab.component';
import { ModalAjoutDemissionComponent } from './collaborateurs/add-edit-collaborateur/add-edit-form-table/_demission_tab/modal-ajout-demission/modal-ajout-demission.component';
import { FormationsCollabComponent } from './formations-collab/formations-collab.component';
import { MdmTableComponent } from './mdm-panel/mdm-table/mdm-table.component';
import { CertificationsCollabComponent } from './certifications-collab/certifications-collab.component';
import { EncodeHttpParamsInterceptor } from './interceptors/encode-http-params.interceptor';
import { AuthentificationInterceptor } from './interceptors/authentification.interceptor';
import { PopupAddFormationsOrCertificationsComponent } from './formations-collab/popup-add-formations-or-certifications/popup-add-formations-or-certifications.component';
import { ContratsComponent } from './collaborateurs/contrats/contrats.component';
import { ModalAjoutContratComponent } from './collaborateurs/contrats/modal-ajout-contrat/modal-ajout-contrat.component';
import { DiplomesComponent } from './collaborateurs/diplomes/diplomes.component';
import { ModalAjoutDiplomeComponent } from './collaborateurs/diplomes/modal-ajout-diplome/modal-ajout-diplome.component';
import { CarrieresComponent } from './collaborateurs/carrieres/carrieres.component';
import { ModalAjoutCarriereComponent } from './collaborateurs/carrieres/modal-ajout-carriere/modal-ajout-carriere.component';
import { CvReaderComponent } from './cv-reader/cv-reader.component';
import { NgxExtendedPdfViewerModule } from 'ngx-extended-pdf-viewer';
import { ModalConfirmDeleteCarriereComponent } from './collaborateurs/carrieres/modal-confirm-delete-carriere/modal-confirm-delete-carriere.component';
import { ModalEditCarriereComponent } from './collaborateurs/carrieres/modal-edit-carriere/modal-edit-carriere.component';

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
    UploadComponent,
    ImportCollabsComponent,
    DownloadComponent,
    AddEditSummaryCardComponent,
    AddEditFormTableComponent,
    TextInputComponent,
    TextareaInputComponent,
    SelectInputComponent,
    HeaderComponent,
    FooterComponent,
    DiplomesComponent,
    ContratsComponent,
    TableComponent,
    MdmPanelComponent,
    HandleStatusDisplayPipe,
    DisplayItemDirective,
    HandleStatusDisplayPipe,
    PopupComponent,
    HeaderFormationCertificationComponent,
    ModalAjoutDiplomeComponent,
    ModalAjoutContratComponent,
    DemissionTabComponent,
    ModalAjoutDemissionComponent,
    FormationsCollabComponent,
    MdmTableComponent,
    CertificationsCollabComponent,
    CarrieresComponent,
    ModalAjoutCarriereComponent,
    CvReaderComponent,
    PopupAddFormationsOrCertificationsComponent,
    ModalConfirmDeleteCarriereComponent,
    ModalEditCarriereComponent,
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
      closeButton: true,
    }),
    PaginationModule.forRoot(),
    BrowserAnimationsModule,
    ngfModule,
    NgxSpinnerModule,
    NgSelectModule,
    NgxExtendedPdfViewerModule,
  ],
  providers: [
    DatePipe,
    {
      provide: HTTP_INTERCEPTORS,
      useClass: AuthentificationInterceptor,
      multi: true,
    },
    { provide: HTTP_INTERCEPTORS, useClass: LoadingInterceptor, multi: true },
    {
      provide: HTTP_INTERCEPTORS,
      useClass: EncodeHttpParamsInterceptor,
      multi: true,
    },
    // { provide: RouteReuseStrategy, useClass: CustomReuseStrategyService },
  ],
  bootstrap: [AppComponent],
})
export class AppModule { }
