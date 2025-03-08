import { Routes } from '@angular/router';
import { EnquiryListComponent } from './Pages/enquiry-list/enquiry-list.component';
import { NewEnquiryComponent } from './Pages/new-enquiry/new-enquiry.component';

export const routes: Routes = [
{
    path:'',
    redirectTo:"list",
    pathMatch:'full'
},

{
    path:"list",
    component:EnquiryListComponent
},
{
        path:"createNew",
        component:NewEnquiryComponent
}

];
