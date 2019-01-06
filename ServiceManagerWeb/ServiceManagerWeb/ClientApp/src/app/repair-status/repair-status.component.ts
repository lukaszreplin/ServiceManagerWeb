import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-repair-status',
  templateUrl: './repair-status.component.html'
})
export class RepairStatusComponent {
  public repair: Repair;
  public isResult : boolean;
  http: HttpClient;
  baseUrl: string;

  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    this.http = http;
    this.baseUrl = baseUrl;
  }

  public queries = {
    email: "",
    repairNumber: ""
  }

  onSave() {
    this.http.get<Repair>(this.baseUrl + 'api/Repair/' + this.queries.repairNumber + '/' + this.queries.email).subscribe(result => {
      this.repair = result;
      console.error(result);
      this.isResult = true;
    }, error => {
      this.isResult = false;
    });
  }
}

interface Repair {
  number: string;
  addedDate: string;
  status: string;
  repairActions: Array<RepairAction>;
  excpectedComplentionDate: string;
  deviceStatus: string;
}

interface RepairAction {
  actionDate: string;
  publicComment: string;
  repairActionDefinition: string;
}
