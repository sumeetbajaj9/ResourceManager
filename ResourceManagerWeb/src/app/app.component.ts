import { Component, OnInit } from '@angular/core';
import { ResourcemanagerService } from './modules/resource-manager/services/resourcemanager.service';


@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent implements OnInit {
  title = 'ResourceManagerWeb';
  constructor(private api: ResourcemanagerService) {}
data:any = [];
skills:any = [];
  ngOnInit(){
    this.getSmartphones();
  }
  
getSmartphones() {
  this.api.getData()
    .subscribe(data => {
      for (const d of (data as any)) {
        this.data.push({
          id:d.EmployeeID,
          name:d.EmployeeName,
          oldproject: d.OldProject,
          oldprojectdate: d.OldProjectDate,
          newproject: d.NewProject,
          newprojectdate:d.NewProjectStartDate,
          skills: d.SkillsMatching
        });
      }
      console.log(this.data);
    });
}
}
