import { Component, NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { LoginComponent } from './login/login.component';
import { PatientMedicationComponent } from './patient-medication/patient-medication.component';
import { PatientbasicrecordComponent } from './patientbasicrecord/patientbasicrecord.component';
import { RegisterComponent } from './register/register.component';


const routes: Routes = [
  
{path:'',component:RegisterComponent},

{
  path:'login',component:LoginComponent
},
{
  path:'register',component:RegisterComponent
},

{
  path:'patientbasicrecord',component:PatientbasicrecordComponent
},
{
  path:'patient-medication',component:PatientMedicationComponent
}


];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
