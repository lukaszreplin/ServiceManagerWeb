import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-repair-status',
  templateUrl: './repair-status.component.html'
})
export class RepairStatusComponent {
  public forecasts: Repair;

  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    http.get<Repair>(baseUrl + 'api/Repair/GetRepairStatus').subscribe(result => {
      this.forecasts = result;
    }, error => console.error(error));
  }
}

interface Repair {
  dateFormatted: string;
  temperatureC: number;
  temperatureF: number;
  summary: string;
}
