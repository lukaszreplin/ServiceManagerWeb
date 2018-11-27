import { ServiceManagerWebPage } from './app.po';

describe('service-manager-web App', function() {
  let page: ServiceManagerWebPage;

  beforeEach(() => {
    page = new ServiceManagerWebPage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
